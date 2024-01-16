namespace ejercicio2.repaso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroEntero;

            do
            {
                Console.WriteLine("Escribame un numero entero de dos cifras: ");
                numeroEntero = Convert.ToInt32(Console.ReadLine());
                if (numeroEntero < 10)
                {
                    Console.WriteLine("Vuelva a escribir el numero y asegurese que sea de dos cifras");
                }
                
                
            }while (numeroEntero < 10);

            int suma = 0;
            int cantidadValores = 0;

            for (int i = 401 ; i < 700; i++)
            {
                suma += i;
                cantidadValores++;

                Console.WriteLine(numeroEntero + " " + "*" + " " + i + " " + "=" + " " + numeroEntero * i);
            }

            int mediaAritmetica = suma / cantidadValores;

            Console.WriteLine("La suma es:" + suma);
            Console.WriteLine("La media aritmetica es: " + mediaAritmetica);

            
        }
    }
}