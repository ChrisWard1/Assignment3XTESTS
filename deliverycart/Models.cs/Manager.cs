namespace deliverycart.Models
{
    public class Manager : Shopper
    {
        public int ManagerID {get;set;}  = default!;
        public string name {get;set;} = default!;
        public string pwd {get;set;} = default!;
        public List<Shopper> Shopper{get;set;}= default!;
    }

}