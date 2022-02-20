namespace deliverycart.Models
{
    public class Shopper : User
    {
        public int ShopperID {get;set;}
        public int CustomerID {get;set;}
              
        public Manager Manager {get; set;}= default!;
        public int SSN {get;set;}
        public int deliveryInfo {get;set;}
        public List<Order> Orders {get;set;}= default!;
    }
}