namespace CheckoutModels.Interfaces
{
    public interface IShoppingListItem
    {
        int ItemId { get; set; }

        string Description { get; set; }

        int Quantity { get; set; }
    }
}
