
namespace CheckoutModels.Models
{
    using System;
    using CheckoutModels.Interfaces;
  
    public class ShoppingListItem : IShoppingListItem
    {
      
        public int ItemId { get; set; }

        public string Description { get; set; }

        public int Quantity { get; set; }
    }
}
