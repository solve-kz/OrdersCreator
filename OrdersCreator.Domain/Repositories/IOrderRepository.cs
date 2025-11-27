using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// IOrderRepository.cs
using OrdersCreator.Domain.Models;

namespace OrdersCreator.Domain.Repositories;

public interface IOrderRepository
{
    Order? GetById(int id);

    /// <summary>Сохраняет заказ вместе со строками.</summary>
    Order Add(Order order);

    void Update(Order order);

    /// <summary>Сохраняет заказ в указанный файл (например, .json).</summary>
    void SaveToFile(Order order, string filePath);

    /// <summary>Загружает заказ из файла.</summary>
    Order LoadFromFile(string filePath);
}

