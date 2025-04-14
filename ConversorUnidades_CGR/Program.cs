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
                Console.WriteLine("1. Medidas de volumen");
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
                        //Volumen
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
                            Console.WriteLine("******CONVERSOR DE UNIDADES DE MEDIDA - MEDIDAS DE VOLUMEN******");
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
                        //Tiempo
                        isAliveSubMenu = true;
                        string[,] arrayConversionTiempo = {
                            {"ms","s","/","1000" },
                            {"ms","m","/","60000"},
                            {"ms","h","/","3.6e+6"},
                            {"s","ms","*","1000"},
                            {"s","m","/","60"},
                            {"s","h","/","3600"},
                            {"m","ms","*","60000"},
                            {"m","s","*","60"},
                            {"m","h","/","60"},
                            {"h","ms","*","3.6e+6"},
                            {"h","s","*","3600"},
                            {"h","m","*","60"},
                        };
                        while (isAliveSubMenu)
                        {
                            Console.Clear();
                            Console.WriteLine("****************************************************************");
                            Console.WriteLine("******CONVERSOR DE UNIDADES DE MEDIDA - MEDIDAS DE TIEMPO******");
                            Console.WriteLine("Seleccione una de las siguientes opciones:");
                            Console.WriteLine("0. Milisegundo a segundo");
                            Console.WriteLine("1. Milisegundo a minuto");
                            Console.WriteLine("2. Milisegundo a hora");
                            Console.WriteLine("3. Segundo a milisegundo");
                            Console.WriteLine("4. Segundo a minuto");
                            Console.WriteLine("5. Segundo a hora");
                            Console.WriteLine("6. Minuto a milisegundo");
                            Console.WriteLine("7. Minuto a segundo");
                            Console.WriteLine("8. Minuto a hora");
                            Console.WriteLine("9. Hora a milisegundo");
                            Console.WriteLine("10. Hora a segundo");
                            Console.WriteLine("11. Hora a minuto");
                            Console.WriteLine("12. Volver al menú anterior ...");
                            string selectedOption = Convert.ToString(Console.ReadLine());
                            if (!selectedOption.All(char.IsNumber))
                            {
                                selectedOption = "-1";
                            }
                            if (Convert.ToInt32(selectedOption) >= 0 && Convert.ToInt32(selectedOption) < 12)
                            {
                                for (int i = 0; i < 12; i++)
                                {
                                    if (Convert.ToInt32(selectedOption) == i)
                                    {
                                        bool isAliveCalculo = true;
                                        do
                                        {

                                            Console.Clear();
                                            Console.WriteLine($"Ingrese la cantidad de {arrayConversionTiempo[i, 0]} para convertir a {arrayConversionTiempo[i, 1]} :");
                                            string valor = Convert.ToString(Console.ReadLine());
                                            //if (!valor.All(char.IsNumber))
                                            if (!Decimal.TryParse(valor, out _))
                                            {
                                                Console.WriteLine("El valor ingresado es incorrecto");
                                                Console.WriteLine("Al presionar cualquier tecla ingrese un valor correcto...");
                                                Console.ReadKey();
                                                isAliveCalculo = true;
                                            }
                                            else
                                            {
                                                decimal valorDec = Convert.ToDecimal(valor);
                                                string signo = arrayConversionTiempo[i, 2];
                                                decimal valorConversion = Decimal.Parse(arrayConversionTiempo[i, 3], NumberStyles.AllowExponent | NumberStyles.AllowDecimalPoint);
                                                decimal resultado = 0;
                                                if (signo == "/")
                                                {
                                                    resultado = valorDec / valorConversion;
                                                }
                                                else
                                                {
                                                    resultado = valorDec * valorConversion;
                                                }

                                                Console.WriteLine($"Resultado: {valorDec} {arrayConversionTiempo[i, 0]} = {resultado.ToString("N2", nfi)} {arrayConversionTiempo[i, 1]}");
                                                Console.ReadKey();
                                                isAliveCalculo = false;
                                            }
                                        }
                                        while (isAliveCalculo);
                                    }
                                }
                            }
                            else if (Convert.ToInt32(selectedOption) == 12)
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
