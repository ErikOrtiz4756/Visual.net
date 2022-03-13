using Programa1.Modelos;

namespace Programa1{
    class PeliculasAdmin{
        private List<Peliculas> _peliculas;

        public PeliculasAdmin(){
            _peliculas = new List<Peliculas>();
        }

        public void MenuPrincipal(){
            int opcionSeleccionada = 0;
            do{
                Console.WriteLine("Ordenar peliculas");
                Console.WriteLine("1.- Listar Peliculas Alfabeticamente");
                Console.WriteLine("2.- Agregar peliculas");
                Console.WriteLine("3.- Modificar peliculas");
                Console.WriteLine("4.- Eliminar pelicula");
                Console.WriteLine("5.- Salir");
            }while (!validaMenu(5, ref opcionSeleccionada));
            switch(opcionSeleccionada){
                case 1:
                    listarPeliculas();
                    break;
                case 2:
                    AgregarPelicula();
                    break;
                case 3:
                    ModificarPelicula();
                    break;
                case 4:
                    eliminarPelicula();
                    break;
                case 5:
                    break;
            }
        }
        
        private void listarPeliculas()
        {
            Console.WriteLine("Lista de Peliculas");
            _peliculas.Sort((p, q) => string.Compare(p.nombre, q.nombre));
            foreach (Peliculas item in _peliculas)
            {
                Console.WriteLine(item.ToString());
            }
            MenuPrincipal();
        }

        private void AgregarPelicula()
        {
            string? nombre;
            string? genero;
            string? autor;
            string? año;
            string? formato;
            Console.WriteLine("Agregar pelicula");
            nombre = pedirValorString("Nombre");
            genero = pedirValorString("Genero");
            autor = pedirValorString("Autor");
            año = pedirValorString("Año");
            formato = pedirValorString("Formato");
            Peliculas nuevaPelicula = new Peliculas(nombre, genero, autor, año, formato);
            _peliculas.Add(nuevaPelicula);
            Console.WriteLine("Pelicula agregada, 'Enter' para continuar...");
            Console.ReadLine();
            MenuPrincipal();
        }

        private void ModificarPelicula(){
            string? nombre = null;
            string? genero;
            string? autor;
            string? año;
            string? formato;
            nombre = pedirValorString("Escribe el Nombre de la Pelicula a Editar");
            Peliculas? PeliculaEdicion = _peliculas.FirstOrDefault(u => u.nombre == nombre);
            if (PeliculaEdicion == null)
            {
                Console.WriteLine("No se encontró la pelicula. Presiona 'Enter' para continuar...");

            }
            else
            {
                genero = pedirValorString("genero");
                PeliculaEdicion.genero = genero;
                autor=pedirValorString("Autor");
                PeliculaEdicion.autor = autor;
                año = pedirValorString("Año");
                PeliculaEdicion.año = año;
                formato = pedirValorString("Formato");
                PeliculaEdicion.formato = formato;
                Console.WriteLine($"La Pelicula con nombre: {PeliculaEdicion.nombre} se editó correctamente. Presiona 'Enter' para continuar...");
            }
            Console.ReadLine();
            MenuPrincipal();
        }

        private void eliminarPelicula()
        {
            string? nombre = null;
            nombre = pedirValorString("Escribe el nombre de la pelicula a borrar");
            Peliculas? PeliculaEliminar = _peliculas.FirstOrDefault(u => u.nombre == nombre);
            if (PeliculaEliminar == null)
            {
                Console.WriteLine("No se encontró la pelicula. Presiona 'Enter' para continuar...");
            }
            else
            {
                _peliculas.Remove(PeliculaEliminar);
                Console.WriteLine($"La pelicula con id: {PeliculaEliminar.nombre} se eliminó correctamente. Presiona 'Enter' para continuar...");
            }

            Console.ReadLine();
            MenuPrincipal();
        }

        private bool validaMenu(int opciones, ref int opcionSeleccionada)
        {
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
        
        private string pedirValorString(string texto)
        {
            string? valor;
            Console.Clear();
            do
            {
                Console.Write($"{texto}: ");
                valor = Console.ReadLine();
                if (valor == null || valor == "")
                {
                    Console.WriteLine("Valor inválido.");
                }
            } while (valor == null || valor == "");
            return valor;
        }

        public void inicializarDatos(){
             Peliculas peliculas = new Peliculas("Señor de los anillos", "Aventura", "J. J. R. Tolkien", "1955", "Cd");
            _peliculas.Add(peliculas);
        }
    }
}