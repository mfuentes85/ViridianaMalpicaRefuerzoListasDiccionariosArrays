string Texto;
string[] palabras = new string[] { };

Console.WriteLine("Por favor introduzca una frase o un texto\n");
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

Console.WriteLine($"\nSon {ContPal.Count} palabras existentes en el texto introducido. Su frecuencia de uso es \n ");
foreach (var conteo in ContPal)
{
    Console.WriteLine($"{conteo.Key} : {conteo.Value}"); 
}
   