﻿using Adagi.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Adagi.Models
{
    [DataContract]
    public class FeatureValue : BaseModel, IUserCreatable
    {
        protected FeatureType _Feature;
        protected object _Value;
        protected User _CreatedBy;
        protected User _LastModifiedBy;

        [DataMember(Name = "Feature")]
        public FeatureType Feature { get { return _Feature; } set { _Feature = value; } }
        [DataMember(Name = "Value")]
        public object Value { get { return _Value; } set { _Value = value; } }

        public FeatureValue()
        {
            Feature = new FeatureType();
            LastModifiedBy = new User();
        }

        public User CreatedBy
        {
            get { return _CreatedBy; }
            set { _CreatedBy = value; }
        }

        public User LastModifiedBy
        {
            get { return _LastModifiedBy; }
            set { _LastModifiedBy = value; }
        }
    }
}