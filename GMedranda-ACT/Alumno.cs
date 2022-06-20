using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMedranda_ACT
{
    public  class Alumno:Persona{
        //Dato de carrera
        private string _carrera;

        public string carrera { 
            get { return _carrera; }
            set { _carrera = value; }

        }
       
        public Alumno()
        {

        }

        public Alumno(int _cedula, string _nombre, string _apellidos, string _carrera,bool _ban):base(
                      _cedula,_nombre,_apellidos,_ban)
        {
            this._carrera = _carrera;
        }


    }
}
