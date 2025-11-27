using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// OrderStatus.cs
namespace OrdersCreator.Domain.Models;

public enum OrderStatus
{
    Draft = 0,
    AtWork = 1,
    Complited = 2
}
