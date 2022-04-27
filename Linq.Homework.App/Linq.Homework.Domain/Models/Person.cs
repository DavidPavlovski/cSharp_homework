using Linq.Homework.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Linq.Homework.Domain.Models
{
    public class Person : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName => $"{FirstName} {LastName}";
        public int Age { get; set; }
        public Job Occupation { get; set; }
        public List<Dog> Dogs { get; set; }
        public Person(string firstName, string lastName, int age, Job occupation)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Occupation = occupation;
            Dogs = new List<Dog>();
        }
        public override string Info()
        {
            string dogCount = Dogs.Count > 0 ? $"owns {Dogs.Count} dogs" : "does not own a dog";
            return $"{FullName} , Age : {Age} , Occupation : {Occupation} , {dogCount}";
        }
    }
}
