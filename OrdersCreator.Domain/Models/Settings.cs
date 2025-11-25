using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Settings.cs
namespace OrdersCreator.Domain.Models;

/// <summary>
/// Настройки приложения (путь к отчётам, звуки, формат штрих-кода и т.п.).
/// </summary>
public sealed class Settings
{
    /// <summary>Папка, куда сохраняются отчёты.</summary>
    public string ReportsDirectory { get; set; } = string.Empty;

    /// <summary>Путь к звуку успешного события.</summary>
    public string? SuccessSoundPath { get; set; }

    /// <summary>Путь к звуку ошибки.</summary>
    public string? ErrorSoundPath { get; set; }

    /// <summary>Общая длина штрих-кода.</summary>
    public int BarcodeLength { get; set; } = 12;

    /// <summary>Сколько символов занимает код товара в штрих-коде.</summary>
    public int ProductCodeLength { get; set; } = 7;

    /// <summary>Сколько символов занимает "сырой" вес в штрих-коде.</summary>
    public int WeightPartLength { get; set; } = 5;

    // при необходимости добавишь сюда остальные опции
}

