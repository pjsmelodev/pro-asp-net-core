﻿namespace LanguageFeatures.Models
{
    public static class MyExtensionMethods
    {
        // this -> faz com que TotalPrices seja um extension method
        // O primeiro parâmetro é o tipo que queremos extender
        //public static decimal TotalPrices(this ShoppingCart cartParam)

        public static decimal TotalPrices(this IEnumerable<Product?> products)
        {
            decimal total = 0;
            //if (cartParam.Products != null)
            //{
            //    foreach (Product? prod in cartParam.Products)
            //    {
            //        total += prod?.Price ?? 0;
            //    }
            //}

            foreach (Product? prod in products)
            {
                total += prod?.Price ?? 0;
            }
            return total;
        }

        public static IEnumerable<Product?> FilterByPrice(this IEnumerable<Product?> producEnum, decimal minimumPrice)
        {
            foreach (Product? prod in producEnum)
            {
                if ((prod?.Price ?? 0) >= minimumPrice)
                {
                    yield return prod;
                }
            }
        }

        //public static IEnumerable<Product?> FilterByName(this IEnumerable<Product?> productEnum, char firstLetter)
        //{
        //    foreach (Product? prod in productEnum)
        //    {
        //        if (prod?.Name[0] == firstLetter)
        //        {
        //            yield return prod;
        //        }
        //    }
        //}

        public static IEnumerable<Product?> Filter(this IEnumerable<Product?> productEnum, Func<Product?, bool> selector)
        {
            foreach (Product? prod in productEnum)
            {
                if (selector(prod))
                {
                    yield return prod;
                }
            }
        }
    }
}