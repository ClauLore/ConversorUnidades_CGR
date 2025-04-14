using System.Globalization;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

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
                            isAliveSubMenu= CalcularConversion(arrayConversionVolumen, selectedOption);
                           
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
                            isAliveSubMenu = CalcularConversion(arrayConversionTiempo, selectedOption);
                        }
                        break;
                    case "3":
                        //Tiempo
                        isAliveSubMenu = true;
                        string[,] arrayConversionTamañoDatos = {
                            {"B","KB","/","1000" },
                            {"B","MB","/","1e+6"},
                            {"B","GB","/","1e+9"},
                            {"B","TB","/","1e+12"},
                            {"B","PB","/","1e+15"},
                            {"KB","B","*","1000" },
                            {"KB","MB","/","1000"},
                            {"KB","GB","/","1e+6"},
                            {"KB","TB","/","1e+9"},
                            {"KB","PB","/","1e+12"},
                            {"MB","B","*","1e+6" },
                            {"MB","KB","*","1000"},
                            {"MB","GB","/","1000"},
                            {"MB","TB","/","1e+6"},
                            {"MB","PB","/","1e+9"},
                            {"GB","B","*","1e+9" },
                            {"GB","KB","*","1e+6"},
                            {"GB","MB","*","1000"},
                            {"GB","TB","/","1000"},
                            {"GB","PB","/","1e+6"},
                            {"TB","B","*","1e+12" },
                            {"TB","KB","*","1e+9"},
                            {"TB","MB","*","1e+6"},
                            {"TB","GB","*","1000"},
                            {"TB","PB","/","1000"},
                        };
                        while (isAliveSubMenu)
                        {
                            Console.Clear();
                            Console.WriteLine("************************************************************************");
                            Console.WriteLine("******CONVERSOR DE UNIDADES DE MEDIDA - MEDIDAS DE TAMAÑO DE DATOS******");
                            Console.WriteLine("Seleccione una de las siguientes opciones:");
                            Console.WriteLine("0. Bytes a Kilobytes");
                            Console.WriteLine("1. Bytes a Megabytes");
                            Console.WriteLine("2. Bytes a Gigabytes");
                            Console.WriteLine("3. Bytes a Terabytes");
                            Console.WriteLine("4. Bytes a Petabytes");
                            Console.WriteLine("5. Kilobytes a Bytes");
                            Console.WriteLine("6. Kilobytes a Megabytes");
                            Console.WriteLine("7. Kilobytes a Gigabytes");
                            Console.WriteLine("8. Kilobytes a Terabytes");
                            Console.WriteLine("9. Kilobytes a Petabytes");
                            Console.WriteLine("10. Megabytes a Bytes");
                            Console.WriteLine("11. Megabytes a Kilobytes");
                            Console.WriteLine("12. Megabytes a Gigabytes");
                            Console.WriteLine("13. Megabytes a Terabytes");
                            Console.WriteLine("14. Megabytes a Petabytes");
                            Console.WriteLine("15. Gigabytes a Bytes");
                            Console.WriteLine("16. Gigabytes a Kilobytes");
                            Console.WriteLine("17. Gigabytes a Megabytes");
                            Console.WriteLine("18. Gigabytes a Terabytes");
                            Console.WriteLine("19. Gigabytes a Petabytes");
                            Console.WriteLine("20. Terabytes a Bytes");
                            Console.WriteLine("21. Terabytes a Kilobytes");
                            Console.WriteLine("22. Terabytes a Megabytes");
                            Console.WriteLine("23. Terabytes a Gigabytes");
                            Console.WriteLine("24. Terabytes a Petabytes");
                            Console.WriteLine("25. Volver al menú anterior ...");
                            string selectedOption = Convert.ToString(Console.ReadLine());
                            if (!selectedOption.All(char.IsNumber))
                            {
                                selectedOption = "-1";
                            }
                            isAliveSubMenu = CalcularConversion(arrayConversionTamañoDatos, selectedOption);
                        }
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

        private static bool CalcularConversion(string[,] arrayConversion, string selectedOption)
        {
            var nfi = new NumberFormatInfo();
            nfi.NumberGroupSeparator = " "; // set the group separator to a space
            nfi.NumberDecimalSeparator = "."; // set decimal separator to comma
            bool isAliveSubMenu = true;

            if (Convert.ToInt32(selectedOption) >= 0 && Convert.ToInt32(selectedOption) < arrayConversion.GetLength(0))
            {
                for (int i = 0; i < arrayConversion.GetLength(0); i++)
                {
                    if (Convert.ToInt32(selectedOption) == i)
                    {
                        bool isAliveCalculo = true;
                        do
                        {

                            Console.Clear();
                            Console.WriteLine($"Ingrese la cantidad de {arrayConversion[i, 0]} para convertir a {arrayConversion[i, 1]} :");
                            string valor = Convert.ToString(Console.ReadLine());
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
                                string signo = arrayConversion[i, 2];
                                decimal valorConversion = Decimal.Parse(arrayConversion[i, 3], NumberStyles.AllowExponent | NumberStyles.AllowDecimalPoint);
                                decimal resultado = 0;
                                if (signo == "/")
                                {
                                    resultado = valorDec / valorConversion;
                                }
                                else
                                {
                                    resultado = valorDec * valorConversion;
                                }

                                Console.WriteLine($"Resultado: {valorDec} {arrayConversion[i, 0]} = {resultado.ToString("N2", nfi)} {arrayConversion[i, 1]}");
                                Console.ReadKey();
                                isAliveCalculo = false;
                            }
                        }
                        while (isAliveCalculo);
                    }
                }
            }
            else if (Convert.ToInt32(selectedOption) == arrayConversion.GetLength(0))
            {
                isAliveSubMenu = false;
            }
            else
            {
                Console.WriteLine("¡Ha seleccionado un opción incorrecta!");
                Console.WriteLine("Al presionar cualquier tecla el menú volverá a cargar...");
                Console.ReadKey();
            }

            return isAliveSubMenu;
        }
    }
}
