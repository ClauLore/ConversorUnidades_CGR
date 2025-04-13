using static System.Net.Mime.MediaTypeNames;

namespace ConversorUnidades_CGR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isAlive=true;
            do
            {
                Console.Clear();
                Console.OutputEncoding = System.Text.Encoding.UTF8;
                Console.WriteLine("*******************************************");
                Console.WriteLine("******CONVERSOR DE UNIDADES DE MEDIDA******");
                Console.WriteLine("Seleccione una de las siguientes opciones:");
                Console.WriteLine("1. Medidas de volúmen");
                Console.WriteLine("2. Medidas de tiempo");
                Console.WriteLine("3. Medidas de tamaño de datos");
                Console.WriteLine("4. Salir");
                string opcionSeleccionada= Convert.ToString(Console.ReadLine());
                if (!opcionSeleccionada.All(char.IsNumber))
                {
                    opcionSeleccionada = "0";
                }

                switch (opcionSeleccionada)
                {
                    case "1":
                        //
                        break;
                    case "2":
                        //
                        break;
                    case "3":
                        //
                        break;
                    case "4":
                        isAlive=false;
                        break;
                    default:
                        Console.WriteLine("¡Ha seleccionado un opción incorrecta!");
                        Console.WriteLine("Al presionar cualquier tecla el menú volverá a cargar...");
                        Console.ReadKey();
                        break;

                }

            } while (isAlive);

        }

    }
}
