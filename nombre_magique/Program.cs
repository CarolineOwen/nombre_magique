// See https://aka.ms/new-console-template for more information

static int demanderNombre(int min, int max) {
    int nombre = min - 1;
    while (((nombre < min) || (nombre > max)))
    {
        Console.WriteLine($"veuillez choisir un nombre entre {min} et {max}");
        string reponse = Console.ReadLine();

        try
        {
            nombre= int.Parse(reponse);
            if ((nombre < min)||(nombre > max))
            {
                Console.WriteLine($"le nombre doit etre compris entre {min} et {max}");
            }
        }
        catch{
            Console.WriteLine("veuillez rentrer un nombre valide");
        }

} 
    return nombre;
}
Random rand = new Random();
const int MAX = 10;
const int MIN= 1;
int MAGIQUE = rand.Next(MIN, MAX+1);
int nombreAffiche = MAGIQUE+1;

for (int nbVies=4 ;nbVies > 0; nbVies--)
{
    Console.WriteLine("il vous reste " + nbVies + " vies.");
    nombreAffiche = demanderNombre(MIN, MAX);
   if (nombreAffiche > MAGIQUE)
    {
        Console.WriteLine("le nombre est plus petit");

    }
    else if (nombreAffiche < MAGIQUE)
    {
        Console.WriteLine("le nombre est plus grand");
        
    }
    else
    {
        break;
    }
   
}

if (nombreAffiche == MAGIQUE)
{
    Console.WriteLine("Bravo");
}
else
{
    Console.WriteLine("vous avez perdu le nombre magique était " + MAGIQUE);
}

//Random rand = new Random();
//int result = rand.Next(1, 10);
//Console.WriteLine("le nombre aléatoire est " + result);
