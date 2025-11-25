using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// IOrderService.cs
using OrdersCreator.Domain.Barcode;
using OrdersCreator.Domain.Models;

namespace OrdersCreator.Domain.Services;

/// <summary>
/// Управляет текущим формируемым заказом (как раньше лист "Работа").
/// </summary>
public interface IOrderService
{
    /// <summary>Текущий "черновик" заказа.</summary>
    Order? CurrentOrder { get; }

    /// <summary>Начать новый заказ для указанного контрагента.</summary>
    Order StartNewOrder(Customer customer, DateTime? date = null);

    /// <summary>Установить/сменить контрагента у текущего заказа.</summary>
    void SetCustomer(Customer customer);

    /// <summary>Добавить строку по уже известному товару.</summary>
    OrderLine AddLine(Product product, decimal weightKg);

    /// <summary>Добавить строку по результату сканирования штрих-кода.</summary>
    OrderLine AddLineFromBarcode(ParsedBarcode parsedBarcode);

    /// <summary>Отменить последнюю строку заказа.</summary>
    void CancelLastLine();

    /// <summary>Промежуточный итог по текущему товару (как G4 в Excel).</summary>
    decimal GetCurrentProductSubtotal(string productCode);
}

