using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPWalkThrough1.Models
{
    public class Person
    {

        public Person()
        {

        }

        public Person(int id, string firstName, string middleName, string lastName):this(firstName,middleName,lastName)
        {
            Id = id;
        }

        public Person(string firstName, string middleName, string lastName):this(firstName,lastName)
        {
            this.MiddleName = middleName;
        }
        

        public Person(string firstName, string lastName):this(firstName)
        {
            this.LastName = lastName;
        }

        public Person(string firstName):this()
        {
            this.FirstName = firstName;
        }

        public int Id { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string FullName
        {
            get { return GetFullName(); }
        }

        private string GetFullName()
        {
            return FirstName+ " "+MiddleName+" "+LastName;
        }
        public string GetReverseFullName
        {
            get { return ReverseFullName();  }
        }
        private string ReverseFullName()
        {
            return LastName + " " + MiddleName + " " + FirstName;
        }
    }
}
