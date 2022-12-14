using System.Text.RegularExpressions;

Console.WriteLine("Please enter your 16-digit credit card number (xxxx-xxxx-xxxx-xxxx): ");
var card = Console.ReadLine();

Regex cardPattern = new Regex("([0-9]{4})-([0-9]{4})-([0-9]{4})-([0-9]{4})");

while (string.IsNullOrEmpty(card) || !cardPattern.IsMatch(card))
{
    Console.Error.WriteLine("Please double-check your 16-digit credit card number (xxxx-xxxx-xxxx-xxxx): ");
    card = Console.ReadLine();
}

card = card.Replace("-", "");
string cardNumberReverse = "";
for (int i = card.Length - 1; i >= 0; i--)
{
    cardNumberReverse += card[i];
}

int cardNumbersSummary = 0;
for (int i = 1; i <= cardNumberReverse.Length; i++)
{
    if (i % 2 == 1)
    {
        cardNumbersSummary += Convert.ToInt32(cardNumberReverse[i - 1].ToString());
        continue;
    }
    else
    {
        int cardNumberMultiplierCheck = Convert.ToInt32(cardNumberReverse[i - 1].ToString()) * 2;
        if (cardNumberMultiplierCheck >= 0)
        {
            int firstDigit = cardNumberMultiplierCheck / 10;
            int lastDigit = cardNumberMultiplierCheck % 10;
            cardNumbersSummary += firstDigit + lastDigit;
            continue;
        }
        cardNumbersSummary += cardNumberMultiplierCheck;
    }
}

if (cardNumbersSummary % 10 == 0)
    Console.WriteLine("This credit card is valid.");
else
    Console.WriteLine("This credit card is invalid!");