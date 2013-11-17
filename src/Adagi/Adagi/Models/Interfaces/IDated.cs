using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Adagi.Models.Interfaces
{
    public interface IDated
    {
        DateTime DateCreated { get; set; }
        DateTime DateLastModified { get; set; }
    }
}
