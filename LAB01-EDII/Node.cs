using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB01_EDII
{
    public class Node<Person>
    {
        public Person Record { get; set; }
        public Node<Person> Left;
        public Node<Person> Right;

        public Node(Person Record)
        {
            this.Record = Record;
        }
    }
}
