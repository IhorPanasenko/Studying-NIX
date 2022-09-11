namespace E_ShopWithOOP.OOP_Hierarchy
{
    public class RegisterUser
    {
        private readonly int id;
        private string firstName;
        private string lastName;
        private DateTime birthdayDate;
        private string password;
        private string login;
        private string email;
        private string phone;
        private Address? defaultAddress;

        internal int Id { get { return id; } }
        internal string FirstName { get { return firstName; } set { FirstName = value != null ? value : firstName; } }
        internal string LastName { get { return lastName; } set { LastName = value != null ? value : lastName; }}
        internal DateTime BirthayDate { get { return birthdayDate; } set { BirthayDate = value != null ? value : birthdayDate; } }
        public string Password { 
            get 
            {
                return password; 
            } 
            set 
            { 
                
            } 
        }   
        

    }
}