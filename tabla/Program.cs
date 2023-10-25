// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

class program
{

    static void Main(string[] args)
    {
        int numero, resultado;
        Console.Write("Ingresa hasta donde deseas obtener la tabla de multiplicar:  ");
        numero = Convert.ToInt32(Console.ReadLine());

        for (int j=1; j <= numero; j++) 
        { 
            Console.WriteLine("La tabla de multiplicar del número {0} es: ", j);

            for (int i = 1; i <= 12; i++)
            {
                resultado = j * i;
                Console.WriteLine("{0} x {1} = {2}", j, i, resultado);
            }
        
        }
    }
}