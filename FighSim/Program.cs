int YourHP =50;
int EnemyHP =50;

string YourName = "Batman";
string EnemyName = "Askungen";

Random generator = new Random();

Console.WriteLine($"Du är {YourName} och ser {EnemyName}. Du känner ilskan i din kropp och blodet börjar koka. DU KOKAR");
Console.WriteLine("Vad gör du åt det?");
Console.WriteLine($"a) Jumpar {EnemyName} b) Poppar en tröcca och blir lugn. c) Slänger en batarang på henne");

string assault = Console.ReadLine().ToLower();

if (assault == "a")
{
 Console.WriteLine($"Du jumpar {EnemyName}. Du lägger en dropkick sen reser du dig");
    while(YourHP > 0 && EnemyHP > 0)
    {
    Console.WriteLine("Starta er runda");
    Console.WriteLine($"{YourName}: {YourHP}  {EnemyName}: {EnemyHP}");
    int SlumpSkada = generator.Next(1,20);
    int SlumpAj = generator.Next(1,20);
    
    EnemyHP -= SlumpSkada;
    EnemyHP = Math.Max(0, EnemyHP);
    Console.WriteLine($"Du ger {EnemyName} en fet högerkrok. Det gör {SlumpSkada} skada");

    YourHP -= SlumpAj;
    YourHP = Math.Max(0, YourHP);
    Console.WriteLine($"Du får en sjuk spark i ansiktet av {EnemyName}. Det gjorde skitont och du förlorade {SlumpAj} skada");
    

    Console.WriteLine("Tryck på valfri knapp för att fortsätta.");
    Console.ReadKey();
    // Samma fast den andra

    }
    Console.WriteLine("\n----- ===== STRIDEN ÄR SLUT ===== -----");

if (YourHP == 0 && EnemyHP == 0)
{
  Console.WriteLine("OAVGJORT. Du är sämst!");
}
else if (YourHP == 0)
{
  Console.WriteLine($"{EnemyName} vann!!!");
}
else
{
  Console.WriteLine($"{YourName} vann!!!");
}

}
if (assault == "b")
{
    Console.WriteLine("Du knäcker en tröcca och börjar klunka den. Du mår bra och går där ifrån");
    Console.WriteLine($"{EnemyName} vann!!!");
}

if (assault == "c")
{
    Console.WriteLine($"Du slänger en batarang på {EnemyName}. Hon ligger på marken. Du tar en tröcca och njuter. Hon dog!");
    Console.WriteLine($"{YourName} vann!!!");
}

Console.ReadLine();