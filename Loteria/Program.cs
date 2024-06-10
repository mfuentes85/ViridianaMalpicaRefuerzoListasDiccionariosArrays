using System.Linq.Expressions;
//Declarando Variales, listas y metodo random
int[] NumGanadores = new int[6];
int ValorUs;
int iteracUsuario=6;
int valor;
int aciertos = 0;
string continuar;
Random random = new Random();
List<int> NumerosUsuario = new List<int>();

//Asignando valores random a array de numeros ganadores
for (int indice = 0; indice <= 5; indice++)
{
    valor = random.Next(1, 49);

    if (valor == 0)
    {
        valor = random.Next(1, 49);
    }
    else if (NumGanadores.Contains(valor))
    {
        valor = random.Next(1, 49);
    }
    else
    {
        NumGanadores[indice] = valor;
    }

}

// Solicitando numeros de los usuarios

Console.WriteLine("\n Bienvenido al juego LOTERIA.\n Para participar deberás introducir 6 números diferentes entre el 1 y el 49 \n ");


    while (iteracUsuario <= 6 && iteracUsuario > 0)
    {
        Console.WriteLine($"Por favor, introduzca un número entre el 1 y el 49");
        ValorUs = int.Parse(Console.ReadLine());

        if (ValorUs > 49)
        {
            Console.WriteLine($"Valor fuera de rango. Introduzca un número entre el 1 y el 49");
            ValorUs = int.Parse(Console.ReadLine());
        }

        else if (NumerosUsuario.Contains(ValorUs))
        {
            Console.WriteLine($"Este número ya existe en la lista, por favor intente otra vez. Introduzca un número diferente entre el 1 y el 49");
            ValorUs = int.Parse(Console.ReadLine());
        }
        else
        {
            NumerosUsuario.Add(ValorUs);

            iteracUsuario--;
            if (iteracUsuario > 0)
            {
                Console.WriteLine($"Le quedan {iteracUsuario} números por ingresar. \n");
            }
            else
            {
                Console.WriteLine("____________________________________________________\n"); ;
            }

        }

    }

    //Evaluando aciertos
    foreach (var item in NumGanadores)
    {
        if (NumerosUsuario.Contains(item))
        {
            aciertos++;
        }
    }
    //Dando resultados
    if (aciertos == 6)
    {
        Console.WriteLine("FELICIDADES, GANASTE LA LOTERÍA");
    }
    else if (aciertos >= 1 && aciertos <= 5)
    {
        Console.WriteLine($"Tuviste {aciertos} aciertos");
    }
    else
    {
        Console.WriteLine("No tuviste ningún acierto, intenta otra vez");
    }

    //Mostrando contenido de array
    Console.WriteLine("\nLos números ganadores son: \n");

    for (int i = 0; i <= 5; i++)
    {
        Console.Write("     " + NumGanadores[i] + "     ");
    }