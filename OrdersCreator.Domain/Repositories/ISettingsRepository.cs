using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// ISettingsRepository.cs
using OrdersCreator.Domain.Models;

namespace OrdersCreator.Domain.Repositories;

public interface ISettingsRepository
{
    Settings Load();
    void Save(Settings settings);
}

