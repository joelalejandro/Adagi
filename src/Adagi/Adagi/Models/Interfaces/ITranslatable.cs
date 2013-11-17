using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adagi.Models.Interfaces
{
    interface ITranslatable
    {
        string Locale { get; set; }
    }
}
