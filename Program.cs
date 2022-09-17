// See https://aka.ms/new-console-template for more information


Console.WriteLine("Scrivi un numero");

long numero = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Il fattoriale è {Fattoriale(numero)}");

//Funzione ricorsiva

long Fattoriale(long number)
{
    if (number <= 1)
    {
        return 1;
    }
    else
    {
        return (number * Fattoriale(number - 1));
    }

}