using Adagi.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Adagi.Models
{
    [DataContract]
    public class BaseModel : IBaseModel, IDated
    {
        protected string _Id;
        protected string _Rev;
        protected DateTime _DateCreated;
        protected DateTime _DateLastModified;

        [DataMember(Name = "Id")]
        public string Id { get { return _Id; } set { _Id = value; } }
        [DataMember(Name = "Rev")]
        public string Rev { get { return _Rev; } set { _Rev = value; } }

        [DataMember(Name = "DateCreated")]
        public DateTime DateCreated
        {
            get
            {
                if (_DateCreated.Equals(DateTime.MinValue))
                {
                    _DateCreated = DateTime.Now;
                }
                return _DateCreated;
            }
            set
            {
                _DateCreated = value;
            }
        }

        [DataMember(Name = "DateLastModified")]
        public DateTime DateLastModified
        {
            get
            {
                if (_DateLastModified.Equals(DateTime.MinValue))
                {
                    _DateLastModified = DateTime.Now;
                }
                return _DateLastModified;
            }
            set
            {
                _DateLastModified = value;
            }
        }
    }
}