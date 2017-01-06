using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person { Name = "Stacey", Age = 30 };
            var ds = new DataContractSerializer(typeof(Person));
            using (Stream s = File.Create("person.xml"))
                ds.WriteObject(s, p);
        }
    }
    [DataContract(Name = "Candidate", Namespace = "http://oreilly.com/nutshell")]//observed by datacontractSerializer
    [XmlRoot(ElementName ="Candidate",Namespace ="http://SomeNamespace")]//observed by XmlSerializer
    public class Person
    {
        [DataMember(Name = "FirstName",Order =10)]
        public string Name;
        [DataMember(Name = "ClaimedAge")]
        public int Age;
        public int SSI;


    }

}
