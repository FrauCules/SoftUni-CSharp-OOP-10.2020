﻿using _905.BirthdayCelebrations.Interfaces;

namespace _905.BirthdayCelebrations.Models
{
    public class Citizen : IId, IBirthable
    {
        public Citizen(string name, int  age, string id, string birthdate)
        {
            Name = name;
            Age = age;
            Id = id;
            Birthdate = birthdate;
        }
        public string Name { get; set; }
        public string Id { get; set; }
        public int Age { get; set; }
        public string Birthdate { get; set; }
    }
}
