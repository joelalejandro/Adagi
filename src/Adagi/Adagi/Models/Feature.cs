using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Adagi.Models
{
    public class Feature : BaseModel
    {
        public string Name { get; set; }
        public FeatureType Type { get; set; }

        public Feature()
        {
            Type = new FeatureType();
        }
    }
}