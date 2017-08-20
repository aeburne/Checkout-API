using CheckoutModels.Interfaces;
using CheckoutModels.Models;
using System.Collections.Generic;

namespace ShoppingListService.Interfaces
{
    public interface IShoppingListService
    {
        IShoppingListItem GetItemById(int id);

        QuantityModel GetQuantityByName(string name);

        List<IShoppingListItem> GetAll();

        ResponseModel AddListItem(IShoppingListItem item);

        ResponseModel RemoveListItem(IShoppingListItem item);

        ResponseModel RemoveListItem(string name);

        ResponseModel RemoveListItem(int id);

        ResponseModel UpdateListItem(IShoppingListItem item);
    }
}
