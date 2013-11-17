using Adagi.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Adagi.Models
{
    [DataContract]
    public class Feature : BaseModel, IOwneable, IUserCreatable, ITranslatable
    {
        protected string _Name;
        protected FeatureType _Type;
        protected Organization _OwnerOrganization;
        protected User _CreatedBy;
        protected User _LastModifiedBy;
        protected string _Locale;

        [DataMember(Name = "Name")]
        public string Name { get { return _Name; } set { _Name = value; } }

        [DataMember(Name = "Type")]
        public FeatureType Type { get { return _Type; } set { _Type = value; } }

        public Feature()
        {
            Type = new FeatureType();
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

        public string Locale
        {
            get { return _Locale; }
            set { _Locale = value; }
        }
    }
}