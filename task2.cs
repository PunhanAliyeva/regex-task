
namespace ConsoleApp11
{
    internal class task2
    {
        static void Main(string[] args)
        {
            string[] employees = new string[0];
            bool flag = true;
            do
            {
                Console.WriteLine("Enter new employee");
                string employee = Console.ReadLine();
                Array.Resize(ref employees, employees.Length + 1);
                employees[employees.Length - 1] = employee;
                Console.WriteLine("Do you want to continue?");
                string answer = Console.ReadLine();
                if (answer.ToUpper() == "YES")
                {
                    continue;
                }
                else
                {
                    flag = false;
                }
            }
            while (flag);
            foreach (string employee in employees) {
                Console.WriteLine(employee);
            }  
            {
                
            }
        }
       

        }
    }