bool replay = true;
Random generator = new Random();

while (replay)
{

  int YourHP = 50;
  int EnemyHP = 50;
  Console.WriteLine("Vad heter du?");
  string YourName = Console.ReadLine();
  string EnemyName = "Askungen";
  Console.WriteLine($"Du är {YourName} och ser {EnemyName}. Du känner ilskan i din kropp och blodet börjar koka. DU KOKAR");
  Console.WriteLine("Vad gör du åt det?");
  Console.WriteLine($"a) Jumpar {EnemyName} b) Poppar en tröcca och blir lugn. c) Tar fram din 9a och poppar henne");

  string assault = "";
  while (assault != "a" && assault != "b" && assault != "c")
  {
    assault = Console.ReadLine().ToLower();

    if (assault != "a" && assault != "b" && assault != "c")
    {
      Console.WriteLine("Du har fan tappat det. JAG SA A B ELLER C");
    }

  }

  if (assault == "a")
  {
    Console.WriteLine($"Du jumpar {EnemyName}. Du lägger en dropkick sen reser du dig");
    while (YourHP > 0 && EnemyHP > 0)
    {
      Console.WriteLine("Starta er runda");
      Console.WriteLine($"{YourName}: {YourHP}  {EnemyName}: {EnemyHP}");
      int SlumpSkada = generator.Next(1, 20);
      int SlumpAj = generator.Next(1, 20);

      EnemyHP -= SlumpSkada;
      EnemyHP = Math.Max(0, EnemyHP);
      Console.WriteLine($"Du ger {EnemyName} en fet högerkrok. Det gör {SlumpSkada} skada");

      YourHP -= SlumpAj;
      YourHP = Math.Max(0, YourHP);
      Console.WriteLine($"Du får en sjuk spark i ansiktet av {EnemyName}. Det gjorde skitont och du förlorade {SlumpAj} skada");


      Console.WriteLine("Tryck på valfri knapp för att fortsätta.");
      Console.ReadKey();

    }
    Console.WriteLine("Fighten är slut");

    if (YourHP == 0 && EnemyHP == 0)
    {
      Console.WriteLine("OAVGJORT. Du är sämst! Kan inte ens vinna.");
    }
    else if (YourHP == 0)
    {
      Console.WriteLine($"{EnemyName} sparkade {YourName} i huvudet så du blev knockad!");
      Console.WriteLine($"{EnemyName} vann!!!");
    }
    else
    {
      Console.WriteLine($"{YourName} la värsta combon och fick {EnemyName} ned på backen.");
      Console.WriteLine($"{YourName} vann!!!");
    }

  }
  else if (assault == "b")
  {
    Console.WriteLine("Du knäcker en tröcca och börjar klunka den. Du mår bra och går där ifrån");
    Console.WriteLine($"{EnemyName} vann!!!");
  }

  else if (assault == "c")
  {
    Console.WriteLine($"Du tar fram en 9a och börjar smattra {EnemyName}. Hon faller ned på marken. Du tar en tröcca och njuter. HON DOG!");
    Console.WriteLine($"{YourName} vann!!!");
  }

  Console.WriteLine("Vill du spela igen? (ja/nej)");
  string replayChoice = Console.ReadLine().ToLower();

  if (replayChoice.ToLower() != "ja")
  {
    replay = false;
    Console.WriteLine("Tack för du har spelat");
  }
}
Console.WriteLine("Tryck på valfri knapp för att avsluta");
Console.ReadLine();