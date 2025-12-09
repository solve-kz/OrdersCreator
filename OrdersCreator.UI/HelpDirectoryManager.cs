using System;
using System.IO;
using System.Windows.Forms;

namespace OrdersCreator.UI
{
    internal static class HelpDirectoryManager
    {
        private const string HelpFolderName = "Help";

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

            if (NeedToCopyHelp(sourceHelpPath, targetHelpPath))
            {
                CopyDirectory(sourceHelpPath, targetHelpPath);
            }

            _helpRoot = targetHelpPath;
            return _helpRoot;
        }

        private static bool NeedToCopyHelp(string sourceHelpPath, string targetHelpPath)
        {
            if (!Directory.Exists(targetHelpPath))
            {
                return true;
            }

            foreach (var sourceFile in Directory.GetFiles(sourceHelpPath, "*", SearchOption.AllDirectories))
            {
                var relativePath = Path.GetRelativePath(sourceHelpPath, sourceFile);
                var targetFilePath = Path.Combine(targetHelpPath, relativePath);

                if (!File.Exists(targetFilePath))
                {
                    return true;
                }

                var sourceInfo = new FileInfo(sourceFile);
                var targetInfo = new FileInfo(targetFilePath);

                if (sourceInfo.LastWriteTimeUtc > targetInfo.LastWriteTimeUtc)
                {
                    return true;
                }
            }

            return false;
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
