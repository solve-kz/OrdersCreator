using System;
using System.IO;
using System.Windows.Forms;

namespace OrdersCreator.UI
{
    internal static class HelpDirectoryManager
    {
        private const string HelpFolderName = "Help";
        private const string VersionFileName = "help.version";

        private static string? _helpRoot;

        public static string HelpRoot => _helpRoot ?? throw new InvalidOperationException("Help directory is not initialized.");

        public static string EnsureHelpDirectoryReady(string appDataPath)
        {
            if (_helpRoot is not null)
            {
                return _helpRoot;
            }

            var sourceHelpPath = Path.Combine(AppContext.BaseDirectory, HelpFolderName);
            if (!Directory.Exists(sourceHelpPath))
            {
                throw new DirectoryNotFoundException($"Source help directory not found: {sourceHelpPath}");
            }

            var targetHelpPath = Path.Combine(appDataPath, HelpFolderName);
            Directory.CreateDirectory(targetHelpPath);

            var currentVersion = GetCurrentVersion();
            if (NeedToCopyHelp(targetHelpPath, currentVersion))
            {
                if (Directory.Exists(targetHelpPath))
                {
                    Directory.Delete(targetHelpPath, recursive: true);
                }

                CopyDirectory(sourceHelpPath, targetHelpPath);
                WriteVersionFile(targetHelpPath, currentVersion);
            }

            _helpRoot = targetHelpPath;
            return _helpRoot;
        }

        private static bool NeedToCopyHelp(string targetHelpPath, Version currentVersion)
        {
            var versionFilePath = Path.Combine(targetHelpPath, VersionFileName);
            if (!File.Exists(versionFilePath))
            {
                return true;
            }

            var storedVersionText = File.ReadAllText(versionFilePath).Trim();
            if (!Version.TryParse(storedVersionText, out var storedVersion))
            {
                return true;
            }

            return storedVersion < currentVersion;
        }

        private static void WriteVersionFile(string targetHelpPath, Version version)
        {
            var versionFilePath = Path.Combine(targetHelpPath, VersionFileName);
            Directory.CreateDirectory(Path.GetDirectoryName(versionFilePath) ?? targetHelpPath);
            File.WriteAllText(versionFilePath, version.ToString());
        }

        private static Version GetCurrentVersion()
        {
            return Version.TryParse(Application.ProductVersion, out var version)
                ? version
                : new Version(0, 0);
        }

        private static void CopyDirectory(string sourceDir, string targetDir)
        {
            Directory.CreateDirectory(targetDir);

            foreach (var file in Directory.GetFiles(sourceDir))
            {
                var targetFilePath = Path.Combine(targetDir, Path.GetFileName(file));
                File.Copy(file, targetFilePath, overwrite: true);
            }

            foreach (var directory in Directory.GetDirectories(sourceDir))
            {
                var targetSubDir = Path.Combine(targetDir, Path.GetFileName(directory));
                CopyDirectory(directory, targetSubDir);
            }
        }
    }
}
