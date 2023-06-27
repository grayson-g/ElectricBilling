namespace ElectricBillingData
{
    public class Customer
    {
        private static int _nextID = 1; 

        public static int NextID { get => _nextID; }

        private int _id;
        private string _firstName;
        private string _lastName;
        private decimal _powerUsedKWh;
        
        public int ID { get => _id; }
        public string FirstName { get => _firstName; }
        public string LastName { get => _lastName; }
        public decimal PowerUsedKWh { get => _powerUsedKWh; }

        public Customer(string FirstName, string LastName, decimal PowerUsedKWh = 0)
        {
            _id = _nextID;
            _firstName = FirstName;
            _lastName = LastName;
            _powerUsedKWh = PowerUsedKWh;

            _nextID++;
        }

        public override string ToString()
            => $"{FirstName} {LastName}";
    }
}