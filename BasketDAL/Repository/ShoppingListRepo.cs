namespace BasketDAL.Repository
{
    using BasketDAL.Interfaces;
    using BasketDAL.Storage;
    using CheckoutModels.Interfaces;
    using CheckoutModels.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ShoppingListRepo : IShoppingListRepo
    {
        public bool AddListItem(IShoppingListItem item)
        {
            // check you dont add the same name multiple times.
            if (ShoppingList.ListItems.Where(d => d.Description == item.Description).Count() == 0)
            {
                // Set the last Id
                item.ItemId = ShoppingList.LastId();
                ShoppingList.ListItems.Add(item);

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RemoveListItem(IShoppingListItem item)
        {
            var itemToRemove = ShoppingList.ListItems.Where(n => n.ItemId == item.ItemId).SingleOrDefault();
            if (itemToRemove != null)
            {
                ShoppingList.ListItems.Remove(itemToRemove);
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RemoveListItem(int id)
        {
            var itemToRemove = ShoppingList.ListItems.Where(n => n.ItemId == id).SingleOrDefault();
            if (itemToRemove != null)
            {
                ShoppingList.ListItems.Remove(itemToRemove);
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool RemoveListItem(string name)
        {
            var itemToRemove = ShoppingList.ListItems.Where(n => n.Description == name).SingleOrDefault();
            if (itemToRemove != null)
            {
                ShoppingList.ListItems.Remove(itemToRemove);
                return true;
            }
            else
            {
                return false;
            }
        }


        public bool UpdateListItem(IShoppingListItem item)
        {
            var itemRem = ShoppingList.ListItems.Where(x => x.ItemId == item.ItemId).SingleOrDefault();

            if (itemRem != null)
            {
                ShoppingList.ListItems.Remove(itemRem);
                ShoppingList.ListItems.Add(item);
                return true;
            }
            else
            {
                return false;
            }

        }

        public IShoppingListItem GetItemById(int id)
        {
            return ShoppingList.ListItems.Where(x => x.ItemId == id).SingleOrDefault();
        }

        public List<IShoppingListItem> GetAll()
        {
            return ShoppingList.ListItems;
        }

        public QuantityModel GetQuantityByName(string name)
        {
            var item = ShoppingList.ListItems.Where(n => n.Description == name).SingleOrDefault();

            if (item != null)
            {
                return new QuantityModel { Quantity = item.Quantity };
            }
            else
            {
                return new QuantityModel();
            }
        }
    }
}
