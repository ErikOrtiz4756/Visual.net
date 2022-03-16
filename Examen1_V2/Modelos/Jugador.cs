namespace Examen1_V2.Modelos{
    public class Jugador {
        private int _balance = 300;

        public Jugador(int balance){
            this._balance = balance;
        }

        public int balance{
            get{ return _balance;}
            set{ _balance = value;}
        }

        public override string ToString()
        {
            return $"Balance del jugador: {balance}";
        }
    }
}