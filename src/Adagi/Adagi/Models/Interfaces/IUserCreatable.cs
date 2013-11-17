using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adagi.Models.Interfaces
{
    public interface IUserCreatable
    {
        User CreatedBy { get; set; }
        User LastModifiedBy { get; set; }
    }
}
