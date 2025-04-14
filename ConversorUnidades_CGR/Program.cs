using System.Globalization;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConversorUnidades_CGR
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var nfi = new NumberFormatInfo();
            nfi.NumberGroupSeparator = " "; // set the group separator to a space
            nfi.NumberDecimalSeparator = "."; // set decimal separator to comma

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
                bool isAliveSubMenu=true;
                switch (opcionSeleccionada)
                {
                    case "1":
                        //Volúmen
                        
                        
                        string [,] arrayConversionVolumen = {
                            {"m3","L","*","1000" },
                            {"m3","ml","*","1e+6"},
                            {"L","m3","/","1000"},
                            {"L","ml","*","1000"},
                            {"ml","m3","/","1e+6"},
                            {"ml","L","/","1000"}
                        };
                        while (isAliveSubMenu)
                        {
                            Console.Clear();
                            Console.WriteLine("****************************************************************");
                            Console.WriteLine("******CONVERSOR DE UNIDADES DE MEDIDA - MEDIDAS DE VOLÚMEN******");
                            Console.WriteLine("Seleccione una de las siguientes opciones:");
                            Console.WriteLine("0. Metro cúbico a litro");
                            Console.WriteLine("1. Metro cúbico a mililitro");
                            Console.WriteLine("2. Litro a metro cúbico");
                            Console.WriteLine("3. Litro a mililitro");
                            Console.WriteLine("4. Mililitro a metro cúbico");
                            Console.WriteLine("5. Mililitro a litro");
                            Console.WriteLine("6. Volver al menú anterior ...");
                            string selectedOption = Convert.ToString(Console.ReadLine());
                            if (!selectedOption.All(char.IsNumber))
                            {
                                selectedOption = "-1";
                            }
                            if (Convert.ToInt32(selectedOption) >= 0 && Convert.ToInt32(selectedOption) < 6)
                            {
                                for (int i = 0;i < 6;i++)
                                {
                                    if (Convert.ToInt32(selectedOption) ==i)
                                    {
                                        bool isAliveCalculo=true;
                                        do
                                        {

                                            Console.Clear() ;   
                                            Console.WriteLine($"Ingrese la cantidad de {arrayConversionVolumen[i, 0]} para convertir a {arrayConversionVolumen[i, 1]} :");
                                            string valor = Convert.ToString(Console.ReadLine());
                                            //if (!valor.All(char.IsNumber))
                                            if(!Decimal.TryParse(valor, out _))
                                            {
                                                Console.WriteLine("El valor ingresado es incorrecto");
                                                Console.WriteLine("Al presionar cualquier tecla ingrese un valor correcto...");
                                                Console.ReadKey();
                                                isAliveCalculo = true;
                                            }
                                            else
                                            {
                                                decimal valorDec = Convert.ToDecimal(valor);
                                                string signo = arrayConversionVolumen[i, 2];
                                                decimal valorConversion = Decimal.Parse(arrayConversionVolumen[i, 3],NumberStyles.AllowExponent | NumberStyles.AllowDecimalPoint);
                                                decimal resultado = 0;
                                                if (signo == "/")
                                                {
                                                    resultado =valorDec / valorConversion;
                                                }
                                                else
                                                {
                                                    resultado=valorDec * valorConversion;
                                                }

                                                Console.WriteLine($"Resultado: {valorDec} {arrayConversionVolumen[i, 0]} = {resultado.ToString("N2", nfi)} {arrayConversionVolumen[i, 1]}");
                                                Console.ReadKey();
                                                isAliveCalculo = false;
                                            }
                                        }
                                        while (isAliveCalculo);
                                    }
                                }
                            }
                            else if(Convert.ToInt32(selectedOption)==6)
                            {
                                isAliveSubMenu = false;
                            }
                            else
                            {
                                Console.WriteLine("¡Ha seleccionado un opción incorrecta!");
                                Console.WriteLine("Al presionar cualquier tecla el menú volverá a cargar...");
                                Console.ReadKey();
                            }
                        }

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
