using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1_V2.Modelos{
    internal class Ruleta{
        private int _giros = 0;
        private int _rojo;
        private int _negro;

        public Ruleta(int giros, int rojo, int negro){
            this._giros = giros;
            this._rojo = rojo;
            this._negro = negro;
        }

        public int giros{
            get {return _giros;}
            set {_giros = value;}
        }

        public int rojo {
            get {return _rojo;}
            set {_rojo = value;}
        }

        public int negro {
            get {return _negro;}
            set {_negro = value;}
        }

        public string ToString(){
            return $"Giros dados: {giros}";
        }
    }
}