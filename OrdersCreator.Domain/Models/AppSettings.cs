using System.IO;

namespace OrdersCreator.Domain.Models
{
    /// <summary>
    /// Глобальные настройки приложения.
    /// </summary>
    public sealed class AppSettings
    {
        private static readonly string DefaultReportsRootFolder = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
            "Отчеты по заказам");

        private static readonly string DefaultReportTemplatePath = Path.Combine(
            DefaultReportsRootFolder,
            "Template",
            "Шаблон.xlsx");

        // ---- Отчёты по заказам ----

        /// <summary>Корневая папка для отчётов.</summary>
        public string ReportsRootFolder { get; set; } = DefaultReportsRootFolder;

        /// <summary>Создавать подпапку с датой внутри корня.</summary>
        public bool UseDailySubfolder { get; set; } = true;

        /// <summary>Путь к .xlsx-шаблону отчёта.</summary>
        public string ReportTemplatePath { get; set; } = DefaultReportTemplatePath;

        /// <summary>Маска имени файла отчёта.</summary>
        /// Например: "Отчёт_{customer_short}_{ДД}-{ММ}-{ГГГГ}_{ЧЧ}-{мм}.xlsx"
        public string ReportFileNameMask { get; set; } =
            "Отчёт_{customer_short}_{ДД}-{ММ}-{ГГГГ}_{ЧЧ}-{мм}.xlsx";

        /// <summary>Открывать ли отчёт в Excel после сохранения.</summary>
        public bool OpenReportAfterSave { get; set; } = true;

        // ---- Блок поведения ----

        /// <summary>Таймаут между символами сканера, мс.</summary>
        public int ScannerCharTimeoutMs { get; set; } = 150;

        /// <summary>Разрешить ручной ввод штрих-кода с клавиатуры.</summary>
        public bool AllowManualBarcodeInput { get; set; } = true;

        /// <summary>Включить/выключить звуки.</summary>
        public bool SoundsEnabled { get; set; } = true;

        /// <summary>Как поступать с неизвестным товаром.</summary>
        public UnknownProductMode UnknownProductMode { get; set; } =
            UnknownProductMode.PromptForData;

        /// <summary>Запрашивать подтверждение при удалении последнего товара.</summary>
        public bool ConfirmDeleteLastProduct { get; set; } = true;

        /// <summary>Запрашивать подтверждение при удалении произвольного товара.</summary>
        public bool ConfirmDeleteAnyProduct { get; set; } = true;

        /// <summary>Запрашивать подтверждение при удалении категории из справочника.</summary>
        public bool ConfirmDeleteCategoryFromCatalog { get; set; } = true;

        /// <summary>Запрашивать подтверждение при удалении товара из справочника.</summary>
        public bool ConfirmDeleteProductFromCatalog { get; set; } = true;

        /// <summary>Запрашивать подтверждение при удалении контрагента из справочника.</summary>
        public bool ConfirmDeleteCustomerFromCatalog { get; set; } = true;

        /// <summary>Запрашивать подтверждение при отмене добавления нового товара.</summary>
        public bool ConfirmCancelNewProduct { get; set; } = true;

        /// <summary>Запрашивать подтверждение при закрытии незавершенного заказа.</summary>
        public bool ConfirmCloseIncompleteOrder { get; set; } = true;

        // ---- Хранение данных ----

        /// <summary>Тип хранилища (InMemory / SQLite / SQL Server).</summary>
        public StorageType StorageType { get; set; } = StorageType.Sqlite;

        /// <summary>
        /// Строка подключения к SQL Server.
        /// Для InMemory/SQLite может быть пустой.
        /// </summary>
        public string SqlServerConnectionString { get; set; } = string.Empty;
    }
}
