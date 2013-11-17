using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Adagi.Models
{
    [DataContract]
    public class Feature : BaseModel
    {
        protected string _Name;
        protected FeatureType _Type;

        [DataMember(Name = "Name")]
        public string Name { get { return _Name; } set { _Name = value; } }

        [DataMember(Name = "Type")]
        public FeatureType Type { get { return _Type; } set { _Type = value; } }

        public Feature()
        {
            Type = new FeatureType();
        }
    }
}