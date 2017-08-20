# Checkout-API
Alex Eburne

Usage of API assuming the localhost is still set as same thing. :-

Post:- http://localhost:50629/ShoppingList2/post

Json in body :-
{
	"Quantity":100,
	"Description":"Coke"

}

Put to update list
http://localhost:50629/ShoppingList2/Put

{
	"ItemId":1,
	"Quantity":160,
	"Description":"Coke"
}

Get whole shopping list
http://localhost:50629/ShoppingList2/Get

Get whole item by id
http://localhost:50629/ShoppingList2/Get/1

Get quantity of Pepsi by name
http://localhost:50629/ShoppingList2/GetQuantity/Pepsi

Delete item by id
http://localhost:50629/ShoppingList2/Delete/1

Delete by name
http://localhost:50629/ShoppingList2/DeleteByName/Pepsi

All of them when using in Post man need the Auth key from the client service layer. This can be put in the header.

Alex
