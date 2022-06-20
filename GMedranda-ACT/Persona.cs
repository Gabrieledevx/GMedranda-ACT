using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GMedranda_ACT{
    public class Persona{
        //Atributos - Datos de persona
        private int _cedula;
        private string _nombre;
        private string _apellidos;
        private bool _ban;
        
        // Definición de getters y Setters
        public int cedula{ 
            get { return _cedula; }
            set { _cedula = value; }
        }

        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string apellidos
        {
            get { return _apellidos; }
            set { _apellidos = value; }
        }

        public bool ban { 
            get { return _ban; }
            set { _ban = false; }
        }
        public Persona() { }

        public Persona(int _cedula, string _nombre, string _apellidos, bool _ban)
        {
            this._cedula = _cedula;
            this._nombre = _nombre;
            this._apellidos = _apellidos;
            this._ban = _ban;
        }

    }
}
