namespace RequiredMembers
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        static void TestEmployee()
        {
            //set required members
            var employee = new Employee { ID = 1001, Name = "Greg Esguerra", Address = "Cebu City" };
            Employee employee1 = new Employee(1001, "Greg Esguerra", "Cebu City");
        }
    }
}
