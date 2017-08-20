namespace BasketDAL.Interfaces
{
    using CheckoutModels.Interfaces;
    using CheckoutModels.Models;
    using System.Collections.Generic;

    public interface IShoppingListRepo
    {
        IShoppingListItem GetItemById(int id);

        QuantityModel GetQuantityByName(string name);

        List<IShoppingListItem> GetAll();

        bool AddListItem(IShoppingListItem item);

        bool RemoveListItem(IShoppingListItem item);

        bool RemoveListItem(int id);

        bool RemoveListItem(string name);

        bool UpdateListItem(IShoppingListItem item);

    }
}
