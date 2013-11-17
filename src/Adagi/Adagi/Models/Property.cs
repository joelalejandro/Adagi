using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Adagi.Models
{
    public class Property : BaseModel
    {
        public string ReferenceCode { get; set; }
        public PropertyType Type { get; set; }
        public FeatureValue[] Features { get; set; }

        public Property()
        {
            Type = new PropertyType();
            Features = new FeatureValue[] { };
        }
    }
}