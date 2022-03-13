using Programa2.Modelos;

namespace Programa2 {
    class ProductosAdmin{
        private List<Productos> _productos;

        public ProductosAdmin(){
            _productos = new List<Productos>();
        }

        public void MenuPrincipal(){
            int opcionSeleccionada = 0;
            do{
                Console.WriteLine("Administrar productos");
                Console.WriteLine("1.- Listar productos por ID");
                Console.WriteLine("2.- Listar productos mas vendidos hasta menos vendidos");
                Console.WriteLine("3.- Agregar producto");
                Console.WriteLine("4.- Modificar producto");
                Console.WriteLine("5.- Eliminar producto ");
                Console.WriteLine("6.- Salir");
            }while (!validaMenu(6, ref opcionSeleccionada));
            switch(opcionSeleccionada){
                case 1:
                    listarProductosID();
                    break;
                case 2:
                    listarProductosV();
                    break;
                case 3:
                    AgregarProducto();
                    break;
                case 4:
                    ModificarProducto();
                    break;
                case 5:
                    EliminarProducto();
                    break;
                case 6:
                    break;
            }
        }

        private void listarProductosID() {
            _productos = _productos.OrderBy(p => p.id).ToList();
            Console.WriteLine("Lista de Productos");
            foreach (Productos item in _productos)
            {
                Console.WriteLine(item.ToString());
            }
            MenuPrincipal();
        }

        private void listarProductosV() {
            _productos = _productos.OrderByDescending(p => p.ventas).ToList();
            Console.WriteLine("Lista de Productos de mas vendido hasta menos vendido");
            foreach (Productos item in _productos)
            {
                Console.WriteLine(item.ToString());
            }
            MenuPrincipal();
        }

        private void AgregarProducto()
        {
            string? id;
            string? nombre;
            string? precio;
            string? ventas;
            string? categorias;
            Console.WriteLine("Agregar producto");
            id = pedirValorString("ID");
            nombre = pedirValorString("Nombre");
            precio = pedirValorString("Precio");
            ventas = pedirValorString("Ventas");
            categorias = pedirValorString("Categoria");
            Productos nuevoProducto = new Productos(id, nombre, precio, ventas, categorias);
            _productos.Add(nuevoProducto);
            Console.WriteLine("Producto agregado, 'Enter' para continuar...");
            Console.ReadLine();
            MenuPrincipal();
        }

        private void ModificarProducto(){
            string? id = null;
            string? nombre;
            string? precio;
            string? ventas;
            string? categorias;
            id = pedirValorString("Escribe el id del producto a modificar");
            Productos? ProductoEdicion = _productos.FirstOrDefault(u => u.id == id);
            if (ProductoEdicion == null)
            {
                Console.WriteLine("No se encontró el Producto. Presiona 'Enter' para continuar...");

            }
            else
            {
                nombre = pedirValorString("Nombre");
                ProductoEdicion.nombre = nombre;
                precio=pedirValorString("Precio");
                ProductoEdicion.precio = precio;
                ventas = pedirValorString("Ventas");
                ProductoEdicion.ventas = ventas;
                categorias = pedirValorString("Categoria");
                ProductoEdicion.categorias = categorias;
                Console.WriteLine($"El producto con id: {ProductoEdicion.id} se editó correctamente. Presiona 'Enter' para continuar...");
            }
            Console.ReadLine();
            MenuPrincipal();
        }

        private void EliminarProducto()
        {
            string? id = null;
            id = pedirValorString("Escribe el id del producto a borrar");
            Productos? ProductoEliminar = _productos.FirstOrDefault(u => u.id == id);
            if (ProductoEliminar == null)
            {
                Console.WriteLine("No se encontró el producto. Presiona 'Enter' para continuar...");
            }
            else
            {
                _productos.Remove(ProductoEliminar);
                Console.WriteLine($"El producto con id: {ProductoEliminar.id} se eliminó correctamente. Presiona 'Enter' para continuar...");
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
             Productos productos = new Productos("1", "Jabon Zote", "50", "1500", "Limpieza");
             _productos.Add(productos);
             Productos productos1 = new Productos("2", "Escoba", "35", "2500", "Limpieza");
             _productos.Add(productos1);

        }
    }
}
