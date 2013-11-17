using Adagi.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Adagi.Models
{
    [DataContract]
    public class Property : BaseModel, IUserCreatable, IOwneable
    {
        protected string _ReferenceCode;
        protected PropertyType _PropertyType;
        protected FeatureValue[] _Features;
        protected Organization _OwnerOrganization;
        protected User _CreatedBy;
        protected User _LastModifiedBy;

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
            CreatedBy = new User();
            LastModifiedBy = new User();
            OwnerOrganization = new Organization();
        }

        public Organization OwnerOrganization
        {
            get { return _OwnerOrganization; }
            set { _OwnerOrganization = value; }
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