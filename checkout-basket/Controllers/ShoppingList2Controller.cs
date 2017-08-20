
namespace checkout_basket.Controllers
{
    using checkout_basket.Filters;
    using CheckoutModels.Interfaces;
    using CheckoutModels.Models;
    using ShoppingListService.Interfaces;
    using ShoppingListService.Services;
    using System.Collections.Generic;
    using System.Web.Http;

    public class ShoppingList2Controller : ApiController
    {
        private IShoppingListService _service;


        public ShoppingList2Controller()
        {
            // Would be done through injection normally
            _service = new ShoppingListService();
        }

        [SecretAuthenticationFilter]
        [HttpGet]
        [Route("ShoppingList2/get")]
        public List<IShoppingListItem> Get()
        {
            return _service.GetAll();
        }

        [SecretAuthenticationFilter]
        [HttpGet]
        [Route("ShoppingList2/get/{id}")]
        public IShoppingListItem Get(int id)
        {
            return _service.GetItemById(id);
        }

        [SecretAuthenticationFilter]
        [HttpGet]
        [Route("ShoppingList2/GetQuantity/{name}")]
        public QuantityModel GetQuantity(string name)
        {
            return _service.GetQuantityByName(name);
        }

        [SecretAuthenticationFilter]
        [HttpPost]
        [Route("ShoppingList2/post")]
        public ResponseModel Post([FromBody]ShoppingListItem value)
        {
            return _service.AddListItem(value);
        }

        [SecretAuthenticationFilter]
        [HttpPut]
        [Route("ShoppingList2/put")]
        public ResponseModel Put([FromBody]ShoppingListItem value)
        {
            return _service.UpdateListItem(value);
        }

        [SecretAuthenticationFilter]
        [HttpDelete]
        [Route("ShoppingList2/Delete/{id}")]
        public ResponseModel Delete(int id)
        {
            return _service.RemoveListItem(id);
           
        }

        [SecretAuthenticationFilter]
        [HttpDelete]
        [Route("ShoppingList2/DeleteByName/{name}")]
        public ResponseModel DeleteByName(string name)
        {
            return _service.RemoveListItem(name);
            
        }
    }
}

