using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Train;
    public class Person
    {
        public string FirstName;
        public string LastName;
        public int age;

        public Person(string FirstName, string LastName, int age)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.age = age;
        }

        public void BemanTrein(Train trein)
        {
            //neem controle over de trein 
            trein.GiveControl(NieuweConducteur: this);
        }
    }
