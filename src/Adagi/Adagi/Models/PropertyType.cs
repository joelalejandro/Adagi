using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Adagi.Models
{
    [DataContract]
    public class PropertyType : BaseModel
    {
        protected string _Name;

        [DataMember(Name = "Name")]
        public string Name { get { return _Name; } set { _Name = value; } }
    }
}