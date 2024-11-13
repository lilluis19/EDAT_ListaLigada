using ListaLigada.Logica;
using System.ComponentModel.Design;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World! Lista ligada simple \n");

        var singleList = new SingleList<String>();

        int opcion = 0;
        do
        {

            opcion = Menu();
            switch (opcion)
            {
                case 1: AgregarElemento(); break;
                case 2: MostrarLista(); break;
                case 3: EliminarElemento() break;
                
                default: Console.WriteLine("La opcion no existe"); 
                    break;
            }

        } while (opcion != 0);

         
        
    void AgregarElemento()
    {
        Console.WriteLine("** Agregar elementos de la lista **");
        Console.WriteLine("Escribe el nombre del nodo : ");
        var nombre = Console.ReadLine();
        singleList.Add(nombre);
    }
        void MostrarLista()
        {
            if (singleList.isEmpty)
            {
                Console.WriteLine("La lista esta vacia");
            }
            else
            {
                Console.WriteLine(singleList);
            }
            Console.WriteLine(singleList);
        }

        Console.ReadKey();

    }//Fin de main

     void EliminarElemento()
    {
        throw new NotImplementedException();
    }

    private static int Menu()
    {
        Console.WriteLine("Menu");
        Console.WriteLine("1. Agregar elemento");
        Console.WriteLine("2. Mostrar lista");
        Console.WriteLine("3. Eliminar lista");

        Console.WriteLine("0. Salir ");

        bool esValido = false;

        int opcion = 0;

        do
        {

            Console.WriteLine("Seleccione una opcion del menu: ");
            var opcionCapturada = Console.ReadLine();
            Console.WriteLine("");

            if (!int.TryParse(opcionCapturada, out opcion) ||opcion < 0 || opcion > 2)
            {
                Console.WriteLine("Ingrese una opcion valida\n");
                esValido = false;
            }
            else
            {
                esValido = true;   
            }


        } while (esValido == false);  

        return opcion;
    }
}