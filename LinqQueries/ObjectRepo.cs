﻿using MockData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqQueries
{
    public class ObjectRepo
    {
        /// <summary>
        /// Id is incremented
        /// </summary>
        /// <param name="person"></param>
        public void Add(Person person)
        {
            var last = People.PeopleList.LastOrDefault();
            if (last != null)
            {
                person.Id = last.Id + 1;
            }
            else
            {
                person.Id = 1;
            }
            People.PeopleList.Add(person);
        }
        public Person GetFirstPerson()
        {
            var query = from p in People.PeopleList
                        select p;
            return query.FirstOrDefault();

            //return People.PeopleList.FirstOrDefault();
        }
        public Person GetPerson(int id)
        {
            //var query = from p in People.PeopleList
            //            where p.Id == 1
            //            select p;

            //return (from p in People.PeopleList
            //        where p.Id == id
            //        select p).FirstOrDefault();

            return People.PeopleList
                .Where(p => p.Id == id)
                .FirstOrDefault();
        }

    }
}
