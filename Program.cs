// ejercicio 1
int a = 1;

Console.WriteLine(" que numero desea multiplicar? ");
int numero = Convert.ToInt32(Console.ReadLine());

while (a<=10)
{
    Console.WriteLine(a + "x" + numero +"=" + (a * numero));
    ++a;
}

// ejercicio 2



int num, positiveCounter = 0, negativeCounter = 0;
        do
        {
            Console.WriteLine("Ingrese un numero (ingresar 0 para salir): ");
            num = int.Parse(Console.ReadLine());
            if (num > 0)
            {
                positiveCounter++;
            }
            else if (num < 0)
            {
                negativeCounter++;
            }
        } while (num != 0);

        Console.WriteLine("Cantidad de numeros positivos ingresados: " + positiveCounter);
        Console.WriteLine("Cantidad de numeros negativos ingresados: " + negativeCounter);

//ejercicio 3


    
        int ancho, alto, cantidad;
        bool relleno;

        Console.WriteLine("Ingrese el ancho del rectángulo: ");
        ancho = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese el alto del rectángulo: ");
        alto = int.Parse(Console.ReadLine());

        Console.WriteLine("Ingrese 1 para rectángulo sin relleno o 2 para rectángulo relleno: ");
        int opcion = int.Parse(Console.ReadLine());
        relleno = (opcion == 2);

        Console.WriteLine("Ingrese la cantidad de rectángulos a dibujar: ");
        cantidad = int.Parse(Console.ReadLine());

        for (int i = 0; i < cantidad; i++)
        {
            for (int j = 0; j < alto; j++)
            {
                for (int k = 0; k < ancho; k++)
                {
                    if (relleno || (j == 0 || j == alto - 1 || k == 0 || k == ancho - 1))
                        Console.Write("*");
                    else
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        Console.ReadLine();
 
