using System;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Newtonsoft.Json;

namespace everymessage.WebAPI.Core.Tests
{
    public static class AttributeHelper
    {
        public static TValue GetPropertyAttributeValue<T, TOut, TAttribute, TValue>(Expression<Func<T, TOut>> propertyExpression, Func<TAttribute, TValue> valueSelector) where TAttribute : Attribute
        {
            var expression = propertyExpression.Body as MemberExpression;

            PropertyInfo propertyInfo = null;

            if (expression != null)
            {
                propertyInfo = expression.Member as PropertyInfo;
            }
            else
            {
                propertyInfo = ((propertyExpression.Body as UnaryExpression).Operand as MemberExpression).Member as PropertyInfo;
            }

            var attr = propertyInfo.GetCustomAttributes(typeof(TAttribute), true).FirstOrDefault() as TAttribute;
            return attr != null ? valueSelector(attr) : default(TValue);
        }

        public static string GetJsonPropertyName<T>(Expression<Func<T, object>> propertyExpression)
        {
            return GetPropertyAttributeValue<T, object, JsonPropertyAttribute, string>(propertyExpression, jp => jp.PropertyName);
        }
    }
}
