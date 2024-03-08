using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumnos
{
    internal class Persona : NombrePersona
    {
        protected string DateOfbirth;

        public string dateofbirth
        {
            get { return DateOfbirth; }
            set { DateOfbirth = value; }
        }

        //constructor

        public Persona() : base()
        {
            dateofbirth = "";
        }

        public Persona(string name, string namefather, string namemother, string datebirth) : base(name, namefather, namemother) 
        {
            this.dateofbirth = datebirth;
        }

        //Methods
        public override string ToString()
        {
            return base.ToString() + "\n" + dateofbirth;
        }

    }
}
