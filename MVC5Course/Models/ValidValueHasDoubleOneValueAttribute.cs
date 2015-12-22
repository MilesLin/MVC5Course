using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC5Course.Models
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class ValidValueHasDoubleOneValueAttribute : DataTypeAttribute
    {
        public ValidValueHasDoubleOneValueAttribute() : base(DataType.Text)
        {
            this.ErrorMessage = "請輸入至少兩個1";
        }

        public override bool IsValid(object value)
        {
            string str = value.ToString();

            return str.Split('1').Count() > 2;
                        
        }
    }
}