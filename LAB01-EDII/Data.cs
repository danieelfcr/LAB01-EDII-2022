using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB01_EDII
{
    class Data
    {
        //Singleton
        private static Data _instance = null;

        public static Data Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Data();
                }
                return _instance;
            }
        }

        public static Func<Person, Person, int> DPIcomparer = (person, newPerson) =>
        {
            return person.dpi.CompareTo(newPerson.dpi);
        };  //Compares two patient nodes by their DPI

        public static Func<Person, Person, int> NameComparer = (person, newPerson) =>
        {
            return person.name.ToLower().CompareTo(newPerson.name.ToLower());
        };  //Compares two patient nodes by their Name


        public AVL<Person> DPITree = new AVL<Person>(DPIcomparer);
        public AVL<Person> NameTree = new AVL<Person>(NameComparer);
    }
}
