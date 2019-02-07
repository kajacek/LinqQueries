using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MockData
{
    public class People
    {
        public static List<Person> PeopleList = new List<Person>
        {
            new Person
            {
                Id = 1,
                Name = "Roman",
                LastName = "Kowalski",
                BirthDate = new DateTime (1900, 1, 1),
                Height = 170,
                Weight = 80
            },
            new Person
            {
                Id = 2,
                Name = "Pawel",
                LastName = "Kowal",
                BirthDate = new DateTime (1910, 1, 1),
                Height = 170,
                Weight = 80
            },
            new Person
            {
                Id = 3,
                Name = "Tomek",
                LastName = "Nowak",
                BirthDate = new DateTime (1920, 1, 1),
                Height = 170,
                Weight = 80
            },
            new Person
            {
                Id = 4,
                Name = "Janek",
                LastName = "Leśniak",
                BirthDate = new DateTime (1930, 1, 1),
                Height = 170,
                Weight = 80
            }
        };
    }
}
