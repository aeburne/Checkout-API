
namespace ShoppingListService.Services
{
    using BasketDAL.Interfaces;
    using BasketDAL.Repository;
    using CheckoutModels.Interfaces;
    using CheckoutModels.Models;
    using global::ShoppingListService.Interfaces;
    using System;
    using System.Collections.Generic;

    public class ShoppingListService : IShoppingListService
    {
        private IShoppingListRepo _ShoppingListRepo;

        public ShoppingListService()
        {
            // Would be done through injection normally
            _ShoppingListRepo = new ShoppingListRepo();
        }

        public ResponseModel AddListItem(IShoppingListItem item)
        {
            if (_ShoppingListRepo.AddListItem(new ShoppingListItem { Description = item.Description, Quantity = item.Quantity }))
            {
                return new ResponseModel { message = "item Added", successfull = true };
            }
            else
            {
                return new ResponseModel { message = "item not Added already there", successfull = false };
            }
        }

        public List<IShoppingListItem> GetAll()
        {
            return _ShoppingListRepo.GetAll();
        }

        public IShoppingListItem GetItemById(int id)
        {
            return _ShoppingListRepo.GetItemById(id);
        }

        public QuantityModel GetQuantityByName(string name)
        {
            return this._ShoppingListRepo.GetQuantityByName(name);
        }

        public ResponseModel RemoveListItem(IShoppingListItem item)
        {
            if(_ShoppingListRepo.RemoveListItem(item))
            {
                return new ResponseModel { successfull = true, message = "Item Deleted" };
            }
            else
            {
                return new ResponseModel { successfull = false, message = "Item doesnt exist" };
            }
        }

        public ResponseModel RemoveListItem(int id)
        {
            if(_ShoppingListRepo.RemoveListItem(id))
            {
                return new ResponseModel { successfull = true, message = "Item Deleted" };
            }
            else
            {
                return new ResponseModel { successfull = false, message = "Item doesnt exist" };
            }

        }

        public ResponseModel RemoveListItem(string name)
        {
            if (_ShoppingListRepo.RemoveListItem(name))
            {
                return new ResponseModel { successfull = true, message = "Item Deleted" };
            }
            else
            {
                return new ResponseModel { successfull = false, message = "Item doesnt exist" };
            }

        }

        public ResponseModel UpdateListItem(IShoppingListItem item)
        {
            if (_ShoppingListRepo.UpdateListItem(item))
            {
                return new ResponseModel { message = "Item updated", successfull = true };
            }
            else
            {
                return new ResponseModel { message = "Item Didnt exist", successfull = false };
            }
        }
    }
}
