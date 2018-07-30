using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Membersips.Extensions
{
    public static class ICollectionExtensions
    {
        public static IEnumerable<SelectListItem> ToSelectListItem<T>(this ICollection<T> items, int selectedValue)
        {
            return from item in items
                select new SelectListItem
                {
                    Text = item.GetProperty("Title"),
                    Value = item.GetProperty("Id"),
                    Selected = item.GetProperty("Id").Equals(selectedValue.ToString())

                };
        }
    }
}