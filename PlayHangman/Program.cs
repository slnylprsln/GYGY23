string[] words = { "selenay", "turkcell", "dondurma", "ramazan", "iftar", "türkay" };

Random r = new Random();
int index = r.Next(words.Length);
string randomWord = words[index];

char[] chars = randomWord.ToCharArray();
char[] stars = new char[chars.Length];
for (int i = 0; i < stars.Length; i++)
{
    stars[i] = '*';
}
foreach (char s in stars)
{
    Console.Write(s);
}

Console.WriteLine();
Console.WriteLine("Your hangman is ready!");

int letterCount = 0;

while (letterCount < chars.Length)
{
    Console.Write("Please enter a letter: ");
    char letter = Console.ReadKey().KeyChar;

    for (int i = 0; i < chars.Length; i++)
    {
        if (chars[i] == letter)
        {
            stars[i] = letter;
            letterCount++;
        }
    }

    Console.WriteLine("\nUpdated hangman version: ");

    foreach (char s in stars)
    {
        Console.Write(s);
    }
    Console.WriteLine("\n");
}

Console.WriteLine("HANGMAN IS OVER!");