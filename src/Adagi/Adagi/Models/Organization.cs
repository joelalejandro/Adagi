using Adagi.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Adagi.Models
{
    [DataContract]
    public class Organization : BaseModel
    {
        protected string _Name;
        protected User[] _Members;

        [DataMember(Name = "Name")]
        public string Name { get { return _Name; } set { _Name = value; } }

        [DataMember(Name = "Members")]
        public User[] Members { get { return _Members; } set { _Members = value; } }

        public Organization()
        {
            Members = new User[] { };
        }
    }
}