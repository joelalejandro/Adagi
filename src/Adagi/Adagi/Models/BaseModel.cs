using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Adagi.Models
{
    public class BaseModel : IBaseModel, IDateInfoModel
    {
        public string Id { get; set; }
        public string Rev { get; set; }
        public string ModelType
        {
            get
            {
                return GetType().Name;
            }
        }


        public DateTime DateCreated
        {
            get;
            set;
        }

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