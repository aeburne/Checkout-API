using System;
using System.Collections.Generic;
using CheckoutModels.Interfaces;
using CheckoutModels.Models;
using System.Linq;

namespace BasketDAL.Storage
{
    /// <summary>
    /// USe this as the 
    /// </summary>
    public static class ShoppingList
    {
        /// <summary>
        /// Date the basket was created
        /// </summary>
        public static DateTime DateCreated { get; set; }

        /// <summary>
        /// Hold the shopping List Items
        /// </summary>
        public static List<IShoppingListItem> ListItems = new List<IShoppingListItem>();

        public static int LastId()
        {
            return ListItems.Count + 1;
        }

        public static void SeedData()
        {
            ListItems.Add(new ShoppingListItem {  ItemId = LastId() , Description = "test", Quantity = 2 });
        }
    }
}
