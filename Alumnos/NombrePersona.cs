using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Alumnos
{
    internal class NombrePersona
    {
        protected string Nombre;
        protected string ApellidoPaterno;
        protected string ApellidoMaterno;

        public string nombre
        {
            get { return Nombre; }
            set {Nombre = value; }
        }
        public string Apellidopaterno
        {
            get { return ApellidoPaterno; }
            set { ApellidoPaterno = value; }
        }
        public string Apellidomaterno
        {
            get { return ApellidoMaterno; }
            set { ApellidoMaterno = value; }
        }

        //constructors
        public NombrePersona()
        {
            nombre = "";
            Apellidopaterno = "";
            Apellidomaterno = "";
        }
        public NombrePersona(string nombre, string apellidopaterno, string apellidomaterno)
        {
            this.nombre = nombre;
            this.Apellidomaterno = apellidomaterno;
            this.Apellidopaterno = apellidopaterno;
        }

        //Methods
        public override string ToString()
        {
            return  nombre + " " + Apellidopaterno + " " + Apellidomaterno;
        }




    }
}
