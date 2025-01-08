/*
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 */


using Shoppingspree;

ClothingItem shirt = new ClothingItem("Men`s T-shirt", 50, 200, "Large", "Blue");
var salePrice = shirt.CalculateSalePrice(40, false);
Console.WriteLine($"The sale price of the shirt is: {salePrice}");
ElectronicItem phone = new ElectronicItem("Iphone X", 25, 3400, "1 year");
salePrice = phone.CalculateSalePrice(10, true);
Console.WriteLine($"The sale price of the phone is: {salePrice}");
