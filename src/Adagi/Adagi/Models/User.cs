using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

namespace Adagi.Models
{
    public class User : MembershipUser, IBaseModel
    {
        public User()
            : base()
        {
            
        }

        public string Id
        {
            get;
            set;
        }

        public string Rev
        {
            get;
            set;
        }

        public string ModelType
        {
            get { return "User"; }
        }
    }
}