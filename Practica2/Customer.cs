namespace Practica2
{
    public class Customer
    {
        public int Id { get; set; }
        public int dni { get; set; }
        public string FullName { get; set; }
        public string email { get; set; }
        public string country { get; set; }
        public int phone { get; set; }


        public Customer()
        {
            
        }

       
        public Customer(int Id, int dni, string FullName, string email, string country, int phone) 
        {
            this.Id = Id;
            this.dni = dni;
            this.FullName = FullName;
            this.email = email;
            this.country = country;
            this.phone = phone; 
        }


    }
}
