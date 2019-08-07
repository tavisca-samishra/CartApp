using System;
using Xunit;
using Cart;

namespace Cart.Tests
{
    public class UnitTest1
    {
        IProduct clothShirt = new Cloth() { Name = "Shirt", Price = 1000, Discount = new Discount(20) };
        IProduct clothJeans = new Cloth() { Name = "Jeans", Price = 2000 , Discount = new Discount(40) };
        IProduct foodFirstFruit = new Food() { Name = "Apple", Price = 100, Discount = new Discount(50) };
        IProduct entertainment = new Entertainment() { Name = "Movie", Price = 500, Discount = new Discount(30) };

        [Fact]
        public void Testing_IProduct()
        {
            Assert.Equal("Jeans", clothJeans.Name);
            Assert.Equal(2000, clothJeans.Price);
            Assert.Equal(1200, clothJeans.GetPriceAfterProductDiscount());
        }
        [Fact]
        public void Testing_CartItem()
        {
            CartItem cartItem = new CartItem();
            cartItem.AddItem(clothShirt);
            cartItem.AddItem(clothShirt);
            cartItem.AddItem(clothJeans);
            Assert.Equal(1600, cartItem.GetPrice(clothShirt));
        }
        [Fact]
        public void Testing_Cart_With_No_Discount()
        {
            CartItem cartItem = new CartItem();
            cartItem.AddItem(clothShirt);
            cartItem.AddItem(entertainment);
            Cart cart = new Cart(cartItem,new Discount(null));
            Assert.Equal(1150, cart.GetTotal());
        }
        [Fact]
        public void Testing_Cart_With_Default_10_Discount()
        {
            CartItem cartItem = new CartItem();
            cartItem.AddItem(clothShirt);
            cartItem.AddItem(foodFirstFruit);
            Cart cart = new Cart(cartItem);
            Assert.Equal(765, cart.GetTotal());
        }
        [Fact]
        public void Testing_Cart_With_Configured_Discount()
        {
            Discount discount = new Discount(50);
            CartItem cartItem = new CartItem();
            cartItem.AddItem(clothShirt);
            cartItem.AddItem(clothJeans);
            cartItem.AddItem(entertainment);
            cartItem.AddItem(foodFirstFruit);
            Cart cart = new Cart(cartItem,discount);
            Assert.Equal(1200, cart.GetTotal());
        }
    }
}
