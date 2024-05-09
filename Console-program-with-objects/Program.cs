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
            if (Age > 10)
            {
                return $"Hi, my name is {FirstName} and last name {LastName}. I am {Age} years old. I am {UserGender}".ToString();
            }
            else
            {
                return $"Hi, my name is {FirstName} and last name {LastName}. I am a baby. I am {UserGender}".ToString();
            }
            
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Age: ");
            string ageInput = Console.ReadLine();
            int ageInt = 0;
            try
            {
                ageInt = Int32.Parse(ageInput);
            }
            catch
            {
                Console.WriteLine("Wrong age");
            }

            User user1 = new User(ageInt);

            Regex regex = new Regex(@"^[a-zA-Z]+$");

            Console.Write("First name: ");
            user1.FirstName = Console.ReadLine();

            Console.Write("Last name: ");
            user1.LastName = Console.ReadLine();

            Console.Write("Gender: ");
            string genderInput = Console.ReadLine();
            genderInput = char.ToUpper(genderInput[0]) + (genderInput.ToLower()).Substring(1);

            if (Enum.TryParse<Gender>(genderInput, out Gender gender))
            {
                user1.UserGender = gender;
            }
            else
            {
                user1.UserGender = Gender.Unknown;
            }

            if (regex.IsMatch(user1.FirstName) && regex.IsMatch(user1.LastName))
            {
                Console.WriteLine(user1.ToString());
            }
            else
            {
                Console.WriteLine("Wrong name");
            }
        }
    }
}
