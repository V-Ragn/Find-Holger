Random randomNumberGenerator = new();

List<string> alphabet = ["a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "æ", "ø", "å"];
string holger = "@";

int holgerX = randomNumberGenerator.Next(0, 40);
int holgerY = randomNumberGenerator.Next(0, 40);

for (int x = 0; x < 40; x++)
{
    for (int y = 0; y < 40; y++)
    {
        if (y == holgerY && x == holgerX)
        {
            Console.Write(holger);
            Console.Write(" ");
        }
        else
        {
            int randomLetter = randomNumberGenerator.Next(0, alphabet.Count);
            Console.Write(alphabet[randomLetter]);
            Console.Write(" ");
        }
    }
    Console.WriteLine();
}