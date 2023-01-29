namespace Cap2_Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el número de lados del polígono:");
            int numeroDeLados = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la longitud de cada lado:");
            double longitudDeLado = double.Parse(Console.ReadLine());

            double perímetro = numeroDeLados * longitudDeLado;

            Console.WriteLine("El perímetro del polígono es: " + perímetro);
        }

        //Ejercicio 2

        /*
                 static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el número de lados del polígono:");
            int numeroDeLados = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la longitud de cada lado:");
            double longitudDeLado = double.Parse(Console.ReadLine());

            double perímetro = numeroDeLados * longitudDeLado;

            Console.WriteLine("El perímetro del polígono es: " + perímetro); ds
        }
         */

        //Ejercicio 3

        /*
         static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el valor en grados a convertir a radianes:");
            double grados = double.Parse(Console.ReadLine());

            double radianes = grados * (Math.PI / 180);

            Console.WriteLine("El valor equivalente en radianes es: " + radianes);
        }
         */

        //Ejercicio 4

        /*
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la temperatura en grados Celsius:");
            double gradosCelsius = double.Parse(Console.ReadLine());

            double gradosFahrenheit = (gradosCelsius * 9 / 5) + 32;

            Console.WriteLine("La temperatura equivalente en grados Fahrenheit es: " + gradosFahrenheit);
        }
         */

        //Ejercicio 5

        /*
                 static void Main(string[] args)
        {
            menu();
        }

        public static void menu()
        {
            Console.WriteLine("Calculadora de cambio entre dolar y euro");
            Console.WriteLine("1.Dolar a euro \n2. Euro a dolar");
            Console.WriteLine("Seleccione una opcion:");
            int op = int.Parse(Console.ReadLine());
            opciones(op);
        }

        public static void opciones(int op)
        {
            switch(op)
            {
                case 1:
                    
                    Console.WriteLine("Introduzca la cantidad de dolar:");
                    double dolar = double.Parse(Console.ReadLine());
                    Console.WriteLine("Introduzca que precio esta el dolar en euros:");
                    double euro = double.Parse(Console.ReadLine());

                    double resultado = 0;

                    resultado = dolar * euro;

                    Console.WriteLine($"Total de euro:{resultado} ");

                    break;

                case 2:

                    Console.WriteLine("Introduzca la cantidad de euro:");
                    double euro_ = double.Parse(Console.ReadLine());
                    Console.WriteLine("Introduzca que precio esta el dolar en dolar:");
                    double dolar_ = double.Parse(Console.ReadLine());

                    double resultado_ = 0;

                    resultado_ = euro_ * dolar_;

                    Console.WriteLine($"Total de dolar:{resultado_} ");

                    break;


            }
        }
         */
    }
}