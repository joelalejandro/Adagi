using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Runtime.Serialization;

namespace Adagi.Models.Interfaces
{
    public interface IBaseModel
    {
        string Id { get; set; }
        string Rev { get; set; }
    }
}