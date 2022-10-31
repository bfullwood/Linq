using System.Xml.Linq;

namespace Linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 10, 2330, 112233, 10, 949, 3764, 2942 };

            //num exercise 
            //Find the Minimum value 
            //Find the Maximum value
            //Find the Maximum value less than 10000
            //Find all the values between 10 and 100
            //Find all the Values between 100000 and 999999 inclusive
            //Count all the even numbers
            //Order the list by descending order, most to least


            int minimum = nums.Min();
            Console.WriteLine("\n1)" + minimum);

            int maximum = nums.Max();
            Console.WriteLine("\n2" + maximum);

            int maxLess = nums.Where(n => n < 10000).Max();
            Console.WriteLine("\n3)" + maxLess);

            List<int> list = nums.Where(n => n > 10 && n < 100).ToList();
            Console.WriteLine("\n4)");

            List<int> list2 = nums.Where(n => n >= 100000 && n <= 999999).ToList();
            Console.Write("\n5)");
          

            int evenNums = nums.Count(n => n % 2 == 0);
            Console.WriteLine("\n6)" + evenNums);

            
            List<int> list3 = nums.OrderByDescending(num => num).ToList();
            Console.Write("\n7)");
            

            List<Student> students = new List<Student>();
            students.Add(new Student("Jimmy", 13));
            students.Add(new Student("Hannah Banana", 21));
            students.Add(new Student("Justin", 30));
            students.Add(new Student("Sarah", 53));
            students.Add(new Student("Hannibal", 15));
            students.Add(new Student("Phillip", 16));
            students.Add(new Student("Maria", 63));
            students.Add(new Student("Abe", 33));
            students.Add(new Student("Curtis", 10));

            //Find all students age of 21 and over (aka US drinking age) 
            //Find the oldest student
            //Find the youngest student
            //Find the oldest student under the age of 25
            //Find all students over 21 and with even ages
            //Find all teenage students(13 to 19 inclusive) 
            //Find all students whose name starts with a vowel
            //Order by student age youngest to oldest

            List<Student> over21 = students.Where(n => n.Age >= 21).ToList();
            Console.Write("\n1) Students over 21:");
            

            
            int oldest = students.Max(n => n.Age);
            Student oldestStudent = students.First(n => n.Age == oldest);
            Console.WriteLine("\n2) The oldest student is: " + oldestStudent.Name);

            
            int youngest = students.Min(n => n.Age);
            Student youngestStudent = students.First(n => n.Age == youngest);
            Console.WriteLine("\n3) The youngest student is: " + youngestStudent.Name);

            
            List<Student> under25 = students.Where(n => n.Age < 25).ToList();
            int oldest25 = under25.Max(n => n.Age);
            Student oldestName = students.First(n => n.Age == oldest25);
            Console.WriteLine("\n4) The oldest student under 25 is: " + oldestName.Name);

            
            List<Student> evenAges = over21.Where(n => n.Age % 2 == 0).ToList();
            Console.Write("\n5) Students over 21 with even ages:");
            
            

            
            List<Student> teenagers = students.Where(n => n.Age >= 13 && n.Age <= 19).ToList();
            Console.Write("\n6) Teenage students:");
         

            string[] vowels = { "A", "E", "I", "O", "U" };

            List<Student> vowelNames = students.Where(n => vowels.Contains(n.Name.Substring(0, 1)) == true).ToList();
            Console.Write("\n7) Students whose name starts with a vowel: ");
                


            List<Student> orderedList = students.OrderBy(n => n.Age).ToList();
            Console.Write("\n8) Students youngest to oldest: ");
           

        }
    }
}