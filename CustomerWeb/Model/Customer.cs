namespace CustomerWeb.Model
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Year { get; set; }

        public Customer(int customerId, string firstName, string lastName, int year)
        {
            CustomerID = customerId;
            FirstName = firstName;
            LastName = lastName;
            Year = year;
        }
    }
}
