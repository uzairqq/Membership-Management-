using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Membersips.Extensions
{
    public static class ReflectionExtensions
    {
        public static string GetProperty<T>(this T item, string propertyName)
        {
            return item.GetType().GetProperty(propertyName).GetValue(item, null).ToString();
        }
    }
}