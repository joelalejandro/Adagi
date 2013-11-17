using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Adagi.Models
{
    public class FeatureValue : BaseModel
    {
        public FeatureType Feature { get; set; }
        public object Value { get; set; }

        public FeatureValue()
        {
            Feature = new FeatureType();
        }
    }
}