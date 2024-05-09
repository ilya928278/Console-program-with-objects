using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using static hillel2.User;

namespace hillel2
{
    public class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; init; }
        public Gender UserGender { get; set; }
        public enum Gender
        {
            Male,
            Female,
            Unknown
        }

        public User()
        {

        }

        public User(int age)
        {
            Age = age;
        }

        public override string ToString()
        {
            return $"Hi, my name is {FirstName} and last name {LastName}. I am {20} years old. I am {UserGender}".ToString();
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            User user1 = new User();
            user1.UserGender = User.Gender.Unknown;

            Regex regex = new Regex(@"^[a-zA-Z]+$");

            Console.Write("First name: ");
            user1.FirstName = (Console.ReadLine());

            Console.Write("Last name: ");
            user1.LastName = (Console.ReadLine());

            if (regex.IsMatch(user1.FirstName) && regex.IsMatch(user1.LastName))
            {
                Console.WriteLine($"FirstName: {user1.FirstName} --- LastName: {user1.LastName}");
            }
            else
            {
                Console.WriteLine("Wrong name");
            }

            Console.WriteLine(user1.ToString());
        }
    }
}
