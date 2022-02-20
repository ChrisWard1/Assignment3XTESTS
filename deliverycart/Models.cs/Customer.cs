#nullable disable
namespace deliverycart.Models
{
    public class Customer : User
    {
        public int CustomerID {get;set;}     
        public string delivAdd {get;set;}= default!;
        //one to many
        public List<Order> Orders {get;set;}= default!;
        
        
    }
}