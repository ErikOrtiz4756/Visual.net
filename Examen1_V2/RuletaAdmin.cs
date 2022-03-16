using Examen1_V2.Modelos;
namespace Examen1_V2{
    class RuletaAdmin{

        int[] rojo = new int[] {2, 4, 6, 8, 10, 11, 13, 15, 17, 20, 22, 24, 26, 28, 29, 31, 33, 35};
        int[] negro = new int[] {1, 3, 5, 7, 9, 12, 14, 16, 18, 19, 21, 23, 25, 27, 30, 32, 34, 36};

        int[] giros = new int[]{0};

        int[] balance = new int[] {300};

        public void MenuPrincipal(){
            int opciones = 0;
            do{
                Console.WriteLine("Bienvenido al juego de la ruleta");
                Console.WriteLine("Selecciona alguna opcion");
                Console.WriteLine("1.- Jugar");
                Console.WriteLine("2.- Revisar estadisticas");
                Console.WriteLine("3.- Salir");
            }while(!validaMenu(3, ref opciones));
            switch(opciones){
                case 1:
                    menuJuego();
                    break;
                case 2:
                    menuEstadisticas();
                    break;

                case 3:
                    //mostrarGoP();
                    break;
            }
        }

        private void menuJuego(){
            int opciones = 0;
            do{
                Console.WriteLine("Vamos a jugar!");
                Console.WriteLine("Selecciona un opcion");
                Console.WriteLine("1.- Apostar a un numero especifico");
                Console.WriteLine("2.- Apostar por un color");
                Console.WriteLine("3.- Apostar si es par o impar");

            }while(!validaMenu(3, ref opciones));
            switch(opciones){
                case 1:
                    apostarEspecifico();
                    break;
                case 2:
                    apostarColor();
                    break;
                case 3:
                    MenuPrincipal();
                    break;
            }
        }

        private void apostarEspecifico(){
            Console.WriteLine("Introduce la cantidad a apostar");
            Console.WriteLine("Tu balance es:" + balance[0]);
            int numero = int.Parse(Console.ReadLine());

            if(balance[0] >= 10){
                if (numero <= balance[0]){
                    if ((numero%10)==0) {
                        Console.WriteLine("Ahora introduce el numero por el cual quieres apostar entre el 0 y el 36");
                        int numeroA = int.Parse(Console.ReadLine());
                        Random rnd = new Random();
                        int numerornd = rnd.Next(0, 2);
                        if(numerornd == 0){
                            int numeroCero = 0;
                            if (numeroCero == numeroA){
                                Console.WriteLine("Felicidades Ganaste!!");
                                int ganancia = numero * 10;
                                balance[0] += ganancia;
                                giros[0] += 1;
                                menuJuego();
                            }else{
                                Console.WriteLine("Perdiste...");
                                balance[0] = balance[0] - numero;
                                giros[0] += 1;
                                menuJuego();
                            }
                        }
                        if(numerornd == 1){
                            Random rnd1 = new Random();
                            int numerornd1 = rnd1.Next(rojo.Length);
                            if (numerornd1 == numeroA){
                                Console.WriteLine("Felicidades Ganaste!!");
                                int ganancia = numero * 10;
                                balance[0] += ganancia;
                                giros[0] += 1;
                                menuJuego();
                            }else {
                                Console.WriteLine("Perdiste...");
                                balance[0] = balance[0] - numero;
                                giros[0] += 1;
                                menuJuego();
                            }
                        }
                        if(numerornd == 2){
                            Random rnd2 = new Random();
                            int numerornd2 = rnd2.Next(negro.Length);
                            if (numerornd2 == numeroA){
                                Console.WriteLine("Felicidades Ganaste!!");
                                int ganancia = numero * 10;
                                balance[0] += ganancia;
                                giros[0] += 1;
                                menuJuego();
                            }else {
                                Console.WriteLine("Perdiste...");
                                balance[0] = balance[0] - numero;
                                giros[0] += 1;
                                menuJuego();
                            }
                        }
                    }else {
                        Console.WriteLine("Perdon tienen que ser multiplos de 10");
                        menuJuego();
                    }
                }else{
                    Console.WriteLine("No tienes el sificinte balance intenta otra vez");
                    menuJuego();
                }
            }else {
                Console.WriteLine("Lo siento se te acabo el dinero tienes que reiniciar");
            }
        }

        public void apostarColor(){
            Console.WriteLine("Introduce la cantidad a apostar");
            Console.WriteLine("Tu balance es:" + balance[0]);
            int numero = int.Parse(Console.ReadLine());
            if(balance[0] > 10){
                if (numero <= balance[0]){
                    Console.WriteLine("Ahora introduce 1 para rojo o 2 para negro");
                    int numeroA = int.Parse(Console.ReadLine());
                    Random rnd = new Random();
                    int numerornd = rnd.Next(0,1);
                    if(numerornd == 0){
                        int rojo = 1;
                        if(rojo == numeroA){
                            Console.WriteLine("Felicidades era color rojo Ganaste!!");
                            int ganancia = numero * 5;
                            balance[0] += ganancia;
                            giros[0] += 1;
                            menuJuego();
                        }else{
                            Console.WriteLine("Perdiste...");
                            balance[0] = balance[0] - numero;
                            giros[0] += 1;
                            menuJuego();
                        }
                    }else{
                        int negro = 2;
                        if(negro == numeroA){
                            Console.WriteLine("Felicidades era color negro Ganaste!!");
                            int ganancia = numero * 5;
                            balance[0] += ganancia;
                            giros[0] += 1;
                            menuJuego();
                        }else{
                            Console.WriteLine("Perdiste...");
                            balance[0] = balance[0] - numero;
                            giros[0] += 1;
                            menuJuego();
                        }
                    }
                }else{
                    Console.WriteLine("No tienes el sificinte balance intenta otra vez");
                    menuJuego();
                }
            }else{
                Console.WriteLine("Lo siento se te acabo el dinero tienes que reiniciar");
            }
        }

        public void menuEstadisticas(){
            int opciones = 0;
            do{
                Console.WriteLine("Revision de estadisticas");
                Console.WriteLine("1.- Revisar balance");
                Console.WriteLine("2.- Historial de giros");
                Console.WriteLine("3.- Regresar al menu principal");
            }while(!validaMenu(3, ref opciones));
            switch(opciones){
                case 1:
                    revisarBalance();
                    break;
                case 2:
                    historialGiros();
                    break;
                case 3:
                    MenuPrincipal();
                    break;
            }
        }

        public void revisarBalance(){
            Console.WriteLine("Tu balance es de: " + balance[0]);
            menuEstadisticas();
        }

        public void historialGiros(){
            Console.WriteLine("EL total de giros es: " + giros[0]);
            menuEstadisticas();
        }

        private bool validaMenu(int opciones, ref int opcionSeleccionada){
            int n;
            if (int.TryParse(Console.ReadLine(), out n))
            {
                if (n <= opciones)
                {
                    opcionSeleccionada = n;
                    return true;
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Opción Invalida.");
                    return false;
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("El valor ingresado no es válido, debes ingresar un número.");
                return false;
            }
        }
    }
}