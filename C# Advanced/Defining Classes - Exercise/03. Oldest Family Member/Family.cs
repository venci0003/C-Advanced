using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03._Oldest_Family_Member
{
    public class Family
    {
        private List<Person> people;

        public Family()
        {
            this.people = new List<Person>();
        }

        public void AddMember(Person member)
        {
            this.people.Add(member);
        }

       public Person GetOldestMember()
        {
            return this.people.OrderByDescending(n => n.Age).FirstOrDefault();
        }
    }
}
