using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Programa2.Modelos{
    internal class Productos {
        private string _id;
        private string _nombre;
        private string _precio;
        private string _ventas;
        private string _categorias;

        public Productos (string id, string nombre, string precio, string ventas, string categorias){
            this._id = id;
            this._nombre = nombre;
            this._precio = precio;
            this._ventas =  ventas;
            this._categorias = categorias;
        }

        public string id {
            get{return _id;}
            set{_id = value;}
        }

        public string nombre {
            get{return _nombre;}
            set{_nombre = value;}
        }

        public string precio {
            get{return _precio;}
            set{_precio = value;}
        }

        public string ventas {
            get{return _ventas;}
            set{_ventas = value;}
        }

        public string categorias {
            get{return _categorias;}
            set{_categorias = value;}
        }

        public override string ToString(){
            return $"ID: {id}, Nombre: {nombre}, Precio: {precio}, Ventas {ventas}, Categoria: {categorias}";
        }
    }
}