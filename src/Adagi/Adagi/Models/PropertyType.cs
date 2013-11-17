using Adagi.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Adagi.Models
{
    [DataContract]
    public class PropertyType : BaseModel, ITranslatable
    {
        protected string _Name;
        protected string _Locale;

        [DataMember(Name = "Name")]
        public string Name { get { return _Name; } set { _Name = value; } }

        public string Locale
        {
            get { return _Locale; }
            set { _Locale = value; }
        }
    }
}