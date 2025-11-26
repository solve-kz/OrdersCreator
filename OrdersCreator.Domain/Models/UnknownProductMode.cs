using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrdersCreator.Domain.Models
{
    public enum UnknownProductMode
    {
        /// <summary>
        /// Показать форму добавления товара (запросить данные).
        /// </summary>
        PromptForData = 0,

        /// <summary>
        /// Только показать сообщение об ошибке.
        /// </summary>
        ShowError = 1
    }
}
