namespace Cap3_Ejercicio1
{
    internal class Program
    {
        //Ejercicio 1
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca un numero: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 0)
                Console.WriteLine("Par");
            else
                Console.WriteLine("Impar");

        }

        // Ejercicio 2

        /*
                 static void Main(string[] args)
        {

            Console.WriteLine("Menu");
            Console.WriteLine("1. Grados a radianes");
            Console.WriteLine("2. Radianes a grados");
            Console.Write("Elija una opción: ");
            int op = int.Parse(Console.ReadLine());

            double resultado;

            switch(op)
            {
                case 1:
                    Console.Write("Ingrese los grados: ");
                    double grados = Convert.ToDouble(Console.ReadLine());
                    resultado = (Math.PI / 180) * grados;
                    Console.WriteLine("{0} grados son {1} radianes.", grados, resultado);
                    break;

                case 2:
                    Console.Write("Ingrese los radianes: ");
                    double radianes = Convert.ToDouble(Console.ReadLine());
                    resultado = (180 / Math.PI) * radianes;
                    Console.WriteLine("{0} radianes son {1} grados.", radianes, resultado);
                    break;

                    default:
                    Console.WriteLine("Opción inválida.");
                    break;

            }

        }
         */


        //Ejercicio 3

        /*
                 static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el nombre del producto: ");
            string nombreProducto = Console.ReadLine();

            Console.WriteLine("Ingrese el precio del producto: ");
            double precioProducto = double.Parse(Console.ReadLine());

            double porcentajeImpuesto = 0.1;

            if (nombreProducto.ToLower() == "medicina")
            {
                porcentajeImpuesto = 0;
            }

            double montoImpuesto = precioProducto * porcentajeImpuesto;
            double precioTotal = precioProducto + montoImpuesto;

            Console.WriteLine("Porcentaje de Impuesto: " + porcentajeImpuesto * 100 + "%");
            Console.WriteLine("Monto de Impuesto: $" + montoImpuesto);
            Console.WriteLine("Precio Total: $" + precioTotal);
        }
         */

        //Ejercicio 4

        /*
                 static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número del 1 al 7: ");
            int numeroDía = int.Parse(Console.ReadLine());

            string nombreDía;
            switch (numeroDía)
            {
                case 1:
                    nombreDía = "Lunes";
                    break;
                case 2:
                    nombreDía = "Martes";
                    break;
                case 3:
                    nombreDía = "Miércoles";
                    break;
                case 4:
                    nombreDía = "Jueves";
                    break;
                case 5:
                    nombreDía = "Viernes";
                    break;
                case 6:
                    nombreDía = "Sábado";
                    break;
                case 7:
                    nombreDía = "Domingo";
                    break;
                default:
                    nombreDía = "Número inválido. Por favor ingrese un número del 1 al 7.";
                    break;
            }

            Console.WriteLine(nombreDía);
        }
         */

        //Ejercicio 5

        /*
                 static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el número de lados del polígono: ");
            int numLados = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la longitud de cada lado: ");
            double longLado = double.Parse(Console.ReadLine());

            Console.WriteLine("Desea calcular el perímetro o el área (Ingrese 'p' para perímetro o 'a' para área)");
            char tipoCalculo = char.Parse(Console.ReadLine());

            double resultado;
            if (tipoCalculo == 'p')
            {
                resultado = numLados * longLado;
                Console.WriteLine("El perímetro del polígono es: " + resultado);
            }
            else if (tipoCalculo == 'a')
            {
                double apotema = CalcularApotema(numLados, longLado);
                resultado = (numLados * longLado) * apotema / 2;
                Console.WriteLine("El área del polígono es: " + resultado);
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor ingrese 'p' para perímetro o 'a' para área.");
            }
        }



      public static double CalcularApotema(int numLados, double longLado)
        {
            double anguloInterior = (180 * (numLados - 2)) / numLados;
            double apotema = longLado / (2 * Math.Tan(anguloInterior / 2));
            return apotema;
        }
         */



    }
}