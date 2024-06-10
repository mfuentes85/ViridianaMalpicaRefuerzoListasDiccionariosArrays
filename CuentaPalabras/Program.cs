string Texto;
string[] palabras = new string[] { };


Console.WriteLine("Por favor introduzca una frase o un texto");
Texto = Console.ReadLine();

palabras = Texto.Split(' ');

Dictionary<string, int> ContPal = new Dictionary<string, int>();

foreach (string palabra in palabras)
{
    if (ContPal.ContainsKey(palabra))
    {
        ContPal[palabra]++;
    }
    else
    {
        ContPal[palabra] = 1;
    }
 }


foreach (var conteo in ContPal)
{
    Console.WriteLine($"{ conteo.Key} : { conteo.Value}"); 
}
   