using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using System.Web.Security;

namespace Adagi.Models
{
    [DataContract]
    public class User : MembershipUser, IBaseModel
    {
        public User()
            : base()
        {
            
        }

        protected string _Id;
        protected string _Rev;

        [DataMember(Name="Id")]
        public string Id
        {
            get { return _Id; }
            set { _Id = value; }
        }

        [DataMember(Name = "Rev")]
        public string Rev
        {
            get { return _Rev; }
            set { _Rev = value; }
        }

        [DataMember(Name = "ModelType")]
        public string ModelType
        {
            get { return "User"; }
        }
    }
}