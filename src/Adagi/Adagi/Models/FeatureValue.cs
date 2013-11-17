using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Adagi.Models
{
    [DataContract]
    public class FeatureValue : BaseModel
    {
        protected FeatureType _Feature;
        protected object _Value;

        [DataMember(Name = "Feature")]
        public FeatureType Feature { get { return _Feature; } set { _Feature = value; } }
        [DataMember(Name = "Value")]
        public object Value { get { return _Value; } set { _Value = value; } }

        public FeatureValue()
        {
            Feature = new FeatureType();
        }
    }
}