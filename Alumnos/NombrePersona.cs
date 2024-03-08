using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumnos
{
    internal class NombrePersona
    {
        protected string FirstName;
        protected string LastNameFather;
        protected string LastNameMother;

        public string firstname
        {
            get { return FirstName; }
            set { FirstName = value; }
        }
        public string lastnamefather
        {
            get { return LastNameFather; }
            set { LastNameFather = value; }
        }
        public string lastnamemother
        {
            get { return LastNameMother; }
            set { LastNameMother = value; }
        }

        //constructors
        public NombrePersona()
        {
            firstname = "";
            lastnamefather = "";
            LastNameMother = "";
        }
        public NombrePersona(string name, string namefather, string namemother)
        {
            this.firstname = name;
            this.lastnamemother = namemother;
            this.lastnamefather = namefather;
        }

        //Methods
        public override string ToString()
        {
            return firstname + " " + lastnamefather + " " + lastnamemother;
        }




    }
}
