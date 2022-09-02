namespace HotelHostingSystemWithCsharp.Models
{
    public class Person
    {
        public Person()
        {
        }

        public Person(string name)
        {
            Name = name;
        }

        public Person(string name, string lastName)
        {
            Name = name;
            LastName = lastName;
        }

        public string Name { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{Name} {LastName}".ToUpper();
    }
}