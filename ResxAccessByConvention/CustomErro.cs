using ResxAccessByConvention.Properties;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ResxAccessByConvention
{
    public class CustomErro : Exception
    {
        public static int ErrorOne { get; set; } = 1;
        public static int ErrorTwo { get; set; } = 2;


        public int ErrorCode { get; set; }
        public string ErrorMessage { get; set; }

        public CustomErro(Expression<Func<int>> expression)
        {
            var body = ((MemberExpression)expression.Body);

            ErrorMessage = Resources.ResourceManager.GetString(body.Member.Name);
            ErrorCode = expression.Compile().Invoke();
        }
    }
}
