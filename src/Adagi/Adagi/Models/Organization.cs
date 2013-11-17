using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Adagi.Models
{
    public class Organization : BaseModel
    {
        public string Name { get; set; }
        public User[] Members { get; set; }

        public Organization()
        {
            Members = new User[] { };
        }
    }
}