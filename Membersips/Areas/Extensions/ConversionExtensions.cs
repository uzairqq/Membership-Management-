﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Membersips.Areas.Admin.Models;
using Membersips.Extensions;
using Membersips.Models;

namespace Membersips.Areas.Extensions
{
    public static class ConversionExtensions
    {
        public static async Task<IEnumerable<ProductModel>> Convert(this IEnumerable<Product> products,
            ApplicationDbContext db)
        {
            if(products.Count().Equals(0))
                return new List<ProductModel>();

            var texts = await db.ProductLinkTexts.ToListAsync();
            var types = await db.ProductTypes.ToListAsync();

            return from p in products
                select new ProductModel
                {
                    Id = p.Id,
                    Title = p.Title,
                    Description = p.Description,
                    ImageUrl = p.ImageUrl,
                    ProductLinkTextId = p.ProductLinkTextId,
                    ProductTypeId = p.ProductTypeId,
                    ProductLinkTexts = texts,
                    ProductTypes = types
                };

        }
    }
}