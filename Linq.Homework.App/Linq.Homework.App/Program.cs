using Linq.Homework.DataAccess;
using Linq.Homework.Domain.Enums;
using Linq.Homework.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq.Homework.App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Find and print all persons firstnames starting with 'R', ordered by Age - DESCENDING ORDER
            Database.People.Where(x => x.FirstName[0] == 'R').OrderBy(y => y.Age).ToList().PrintEntities();

            // Find and print all persons firstnames and lastnames with job Dentist with age below 32
            Database.People.Where(x => x.Occupation == Job.Dentist && x.Age <= 32).ToList().PrintEntities();

            // Find and print all brown dogs names and ages older than 3 years, ordered by Age - ASCENDING ORDER
            Database.Dogs.Where(x => x.Age > 3 && x.Color == "Brown").OrderBy(y => y.Age).ToList().PrintEntities();

            // Find and print all persons names with more than 2 dogs, ordered by Name - DESCENDING ORDER
            Database.People.Where(x => x.Dogs.Count > 2).OrderByDescending(y => y.FirstName).ToList().PrintEntities();

            // Find and print all black dogs names from race dalmatins, order by Age - ASCENDING ORDER
            Database.Dogs.Where(x => x.Color == "Black" && x.Race == Race.Dalmatian).OrderBy(y => y.Age).ToList().PrintEntities();

            // Find and print all Freddy`s dogs names older than 1 year
            Database.People.FirstOrDefault(x => x.FirstName == "Freddy").Dogs.Where(y => y.Age > 1).ToList().PrintEntities();

            // Find and print all persons firstnames with job developer, don't have dogs and are younger than 25 years, order by age - ASCENDING ORDER
            Database.People.Where(x => x.Occupation == Job.Developer && x.Dogs.IsEmpty() && x.Age < 25).OrderBy(x => x.Age).ToList().PrintEntities();

            // Find and print Nathen`s first dog
            Database.People.FirstOrDefault(x => x.FirstName == "Nathen").Dogs.First().PrintEntity();

            // Find and print all Freddy Gordin's dogs from race boxer and bulldog older than 1 year, ordered by name - DESCENDING ORDER
            Database.People.FirstOrDefault(x => x.FullName == "Freddy Gordon").Dogs
                .Where(y => (y.Race == Race.Boxer || y.Race == Race.Bulldog) && y.Age > 1)
                .OrderBy(z => z.Name).ToList().PrintEntities();

            // Find and print all white dogs names from Cristofer, Freddy, Erin and Amelia, ordered by Name - ASCENDING ORDER
            Database.People.Where(x => "Cristofer,Freddy,Erin,Amelia".Contains(x.FirstName))
                .SelectMany(y => y.Dogs).Where(z => z.Color == "White").OrderBy(o => o.Name).ToList().PrintEntities();
        }
    }
}
