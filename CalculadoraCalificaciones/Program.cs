List<double> Calificaciones = new List<double>();
double CantCalif;
double mayor;
double menor;
double promedio;

Console.WriteLine("Introduzca la cantidad de calificaciones que dará de alta");
CantCalif = double.Parse(Console.ReadLine());

do
{
    Console.WriteLine("\nIntroduzca la calificación.");
    Calificaciones.Add(double.Parse(Console.ReadLine()));
    CantCalif--;

    if (CantCalif > 0)
    {
        Console.WriteLine(+ CantCalif + " calificaciones por ingresar\n");

    }

}
while (CantCalif > 0);

Console.WriteLine($"\nLa calificación mayor introducida es {mayor = Calificaciones.Max()}. \nLa calificación menor introducida es {menor = Calificaciones.Min()}\nEl promedio de las calificaciones ingresadas es {Calificaciones.Sum() / Calificaciones.Count}");

    
    

