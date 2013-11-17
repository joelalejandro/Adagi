using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Adagi.Models
{
    [DataContract]
    public class Property : BaseModel
    {
        protected string _ReferenceCode;
        protected PropertyType _PropertyType;
        protected FeatureValue[] _Features;

        [DataMember(Name = "ReferenceCode")]
        public string ReferenceCode { get { return _ReferenceCode; } set { _ReferenceCode = value; } }
        [DataMember(Name = "Type")]
        public PropertyType Type { get { return _PropertyType; } set { _PropertyType = value; } }
        [DataMember(Name = "Features")]
        public FeatureValue[] Features { get { return _Features; } set { _Features = value; } }

        public Property()
        {
            Type = new PropertyType();
            Features = new FeatureValue[] { };
        }
    }
}