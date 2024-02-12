using System.Diagnostics.CodeAnalysis;

namespace RequiredMembers
{
    public class Employee
    {
        public required int ID { get; set; } = 0;
        public required string Name { get; set; } = string.Empty;
        public required string Address { get; set; } = string.Empty;
        public int Age { get; set; } = 0;


        public Employee()
        {
            //default constructor        
        }

        [SetsRequiredMembers]
        public Employee(int id, string name, string address)
        {
            ID = id;
            Name = name;
            Address = address;                
        }
    }
}
