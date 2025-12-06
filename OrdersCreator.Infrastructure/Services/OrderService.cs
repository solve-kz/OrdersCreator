using OrdersCreator.Domain.Barcode;
using OrdersCreator.Domain.Models;
using OrdersCreator.Domain.Services;
using System;
using System.Linq;

namespace OrdersCreator.Infrastructure.Services
{
    public class OrderService : IOrderService
    {
        private readonly IProductService _productService;
        private Order _currentOrder;
        private OrderLine? _lastAddedLine;

        public OrderService(IProductService productService)
        {
            _productService = productService;
            _currentOrder = CreateDraft();
        }

        public Order? CurrentOrder => _currentOrder;

        public Order StartNewOrder(Customer? customer = null, DateTime? date = null)
        {
            _currentOrder = CreateDraft(date);
            _lastAddedLine = null;

            if (customer != null)
            {
                SetCustomer(customer);
            }

            return _currentOrder;
        }

        public void SetCustomer(Customer customer)
        {
            if (customer is null)
                throw new ArgumentNullException(nameof(customer));

            EnsureCurrentOrder();

            _currentOrder.Customer = customer;
            _currentOrder.CustomerId = customer.Id;
            _currentOrder.Status = OrderStatus.AtWork;
        }

        public OrderLine AddLine(Product product, decimal weightKg)
        {
            if (product is null)
                throw new ArgumentNullException(nameof(product));

            if (weightKg <= 0)
                throw new ArgumentOutOfRangeException(nameof(weightKg), "Вес должен быть больше нуля.");

            EnsureCurrentOrder();
            EnsureCustomerSelected();

            var line = new OrderLine
            {
                Product = product,
                ProductId = product.Id,
                ItemsCount = 1,
                WeightKg = weightKg,
                RowNumber = _currentOrder.Lines.Count + 1,
                Order = _currentOrder,
                OrderId = _currentOrder.Id
            };

            _currentOrder.Lines.Add(line);
            _lastAddedLine = line;
            _currentOrder.Status = OrderStatus.AtWork;

            return line;
        }

        public OrderLine AddLineFromBarcode(ParsedBarcode parsedBarcode)
        {
            if (parsedBarcode is null)
                throw new ArgumentNullException(nameof(parsedBarcode));

            var product = _productService.FindByCode(parsedBarcode.ProductCode)
                ?? throw new InvalidOperationException($"Товар с кодом {parsedBarcode.ProductCode} не найден.");

            return AddLine(product, parsedBarcode.WeightKg);
        }

        public void CancelLastLine()
        {
            EnsureCurrentOrder();

            _lastAddedLine ??= _currentOrder.Lines.LastOrDefault();

            if (_lastAddedLine == null)
                return;

                _currentOrder.Lines.Remove(_lastAddedLine);
            _lastAddedLine = _currentOrder.Lines.LastOrDefault();

            if (_currentOrder.Lines.Count == 0 && _currentOrder.CustomerId == 0)
            {
                _currentOrder.Status = OrderStatus.Draft;
            }
        }

        public void RemoveLine(int rowNumber)
        {
            EnsureCurrentOrder();

            var lineToRemove = _currentOrder.Lines.FirstOrDefault(l => l.RowNumber == rowNumber);

            if (lineToRemove == null)
                return;

            _currentOrder.Lines.Remove(lineToRemove);

            for (int i = 0; i < _currentOrder.Lines.Count; i++)
            {
                _currentOrder.Lines[i].RowNumber = i + 1;
            }

            _lastAddedLine = _currentOrder.Lines.LastOrDefault();

            if (_currentOrder.Lines.Count == 0 && _currentOrder.CustomerId == 0)
            {
                _currentOrder.Status = OrderStatus.Draft;
            }
        }

        public decimal GetCurrentProductSubtotal(string productCode)
        {
            EnsureCurrentOrder();

            if (string.IsNullOrWhiteSpace(productCode))
                return 0;

            var normalized = productCode.Trim();
            return _currentOrder
                .Lines
                .Where(l => l.Product?.Code == normalized)
                .Sum(l => l.WeightKg);
        }

        private static Order CreateDraft(DateTime? date = null)
        {
            return new Order
            {
                Date = date ?? DateTime.Now,
                Status = OrderStatus.Draft
            };
        }

        private void EnsureCurrentOrder()
        {
            _currentOrder ??= CreateDraft();
        }

        private void EnsureCustomerSelected()
        {
            if (_currentOrder.Customer == null && _currentOrder.CustomerId == 0)
                throw new InvalidOperationException("Контрагент не выбран.");
        }

        public void LoadOrder(Order order)
        {
            if (order is null)
                throw new ArgumentNullException(nameof(order));

            _currentOrder = order;

            // Перенумеровать строки, если надо
            for (int i = 0; i < _currentOrder.Lines.Count; i++)
            {
                _currentOrder.Lines[i].RowNumber = i + 1;
            }

            _lastAddedLine = _currentOrder.Lines.LastOrDefault();
        }
    }
}
