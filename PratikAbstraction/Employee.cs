using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PratikAbstraction
{
    public abstract class Employee
    {
        protected string _name { get; set; }
        protected string _surname { get; set; }
        protected string _department { get; set; }

        public Employee(string name, string surname, string department)
        {
            _name = name;
            _surname = surname;
            _department = department;
        }
        public abstract void Gorev();
    }
    public class YazılımGeliştirici : Employee
    {
        public YazılımGeliştirici(string name, string surname, string department)
            : base(name, surname, department)
        {
        }
        public override void Gorev()
        {
            Console.WriteLine("Yazılım geliştiriyorum.");
        }
    }
    public class ProjeYoneticisi : Employee
    {
        public ProjeYoneticisi(string name, string surname, string department)
            : base(name, surname, department)
        {
        }
        public override void Gorev()
        {
            Console.WriteLine("Proje Yöneticiliği yapıyorum.");
        }
    }
    public class SatısTemsilcisi : Employee
    {
        public SatısTemsilcisi(string name, string surname, string department)
            : base(name, surname, department)
        {
        }
        public override void Gorev()
        {
            Console.WriteLine("Satış Temsilciliği yapıyorum.");
        }
    }
}
