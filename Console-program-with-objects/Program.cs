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


}
