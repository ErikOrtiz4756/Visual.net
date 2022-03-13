using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programa1.Modelos{
    internal class Peliculas{
        private string _nombre;
        private string _genero;
        private string _autor;
        private string _año;
        private string _formato;
        private string año1;

        public Peliculas(string nombre, string genero, string autor, string año, string formato)
        {
            this._nombre = nombre;
            this._genero = genero;
            this._autor = autor;
            this._año = año;
            this._formato = formato;
        }

        public string nombre
        {
            get { return _nombre;}
            set { _nombre = value;}
        }


        public string genero
        {
            get { return _genero; }
            set { _genero = value; }
        }


        public string autor
        {
            get { return _autor; }
            set { _autor = value; }
        }

        public string año
        {
            get { return _año; }
            set { _año = value; }
        }

        public string formato
        {
            get { return _formato; }
            set { _formato = value; }
        }

                public override string ToString()
        {
            return $"Nombre: {_nombre}, Genero: {genero}, Autor: {autor}, Año: {año}, Formato: {formato}";
        }
    }
}
