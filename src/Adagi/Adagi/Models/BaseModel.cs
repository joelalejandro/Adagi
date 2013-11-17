using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Runtime.Serialization;

namespace Adagi.Models
{
    [DataContract]
    public class BaseModel : IBaseModel, IDateInfoModel
    {
        protected string _Id;
        protected string _Rev;

        [DataMember(Name="Id")]
        public string Id { get { return _Id; } set { _Id = value; } }
        [DataMember(Name = "Rev")]
        public string Rev { get { return _Rev; } set { _Rev = value; } }
        [DataMember(Name="ModelType")]
        public string ModelType
        {
            get
            {
                return GetType().Name;
            }
        }

        [DataMember(Name="DateCreated")]
        public DateTime DateCreated
        {
            get;
            set;
        }

        [DataMember(Name="DateLastModified")]
        public DateTime DateLastModified
        {
            get;
            set;
        }
    }

    public interface IBaseModel
    {
        string Id { get; set; }
        string Rev { get; set; }
        string ModelType { get; }
    }

    public interface IDateInfoModel
    {
        DateTime DateCreated { get; set; }
        DateTime DateLastModified { get; set; }
    }
}