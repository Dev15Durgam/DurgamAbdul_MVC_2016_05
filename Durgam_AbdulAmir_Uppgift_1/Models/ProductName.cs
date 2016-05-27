using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Durgam_AbdulAmir_Uppgift_1.Models
{
   public class ProductName :ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            if (value == null)
                return false;

            var ToCheck =
                value.ToString().ToLower(); return
                !ToCheck.StartsWith("p_");
                //!ToCheck.EndsWith("[1-9][1,4]")

        }
        public override string FormatErrorMessage(string field)
        {
            return field + "Product Number should start with a P and then followed by hyphen - and then finished by a number between 1-9";
        }
    }

    //public class TestValidation : RegularExpressionAttribute
    //{
    //    public TestValidation(string pattern) : base(pattern)
    //    {
    //    }

    //    public override bool IsValid(object value)
    //    {
    //        return base.IsValid(value);
    //    }
    //}
}
