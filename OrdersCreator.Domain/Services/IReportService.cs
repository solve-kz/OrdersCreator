using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// IReportService.cs
using OrdersCreator.Domain.Models;

namespace OrdersCreator.Domain.Services;

/// <summary>
/// Готовит данные для отчёта (шапка, строки, подвал).
/// Экспорт в Excel/PDF будет уже в Infrastructure.
/// </summary>
public interface IReportService
{
    /// <summary>
    /// Финализирует заказ и возвращает "готовую" модель для печати.
    /// </summary>
    Order CompleteOrder(Order order);

    /// <summary>
    /// Формирует Excel-отчёт по заказу и возвращает путь к сохранённому файлу.
    /// </summary>
    string CreateReport(Order order);
}

