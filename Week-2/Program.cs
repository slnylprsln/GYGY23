Console.WriteLine("Please enter a password: ");
string password = Console.ReadLine();

if (string.IsNullOrEmpty(password))
{
    Console.WriteLine("Password cannot be null!");
}
else
{
    if (password.Length < 6)
    {
        Console.WriteLine("Password should be longer than 6 characters!");
    }
    else
    {
        char[] chars = password.ToCharArray();
        int digit = 0;
        int letter = 0;
        int other = 0;

        for (int i = 0; i < chars.Length; i++)
        {
            if (char.IsDigit(chars[i])) digit++;
            if (char.IsLetter(chars[i])) letter++;
            if (!char.IsLetterOrDigit(chars[i])) other++;
        }

        if ((digit != 0 && letter == 0 && other == 0) || (digit == 0 && letter != 0 && other == 0))
        {
            Console.WriteLine("Sorry, the password you entered is WEAK.");
        }
        else if (digit != 0 && letter != 0 && other == 0)
        {
            Console.WriteLine("The password you entered is MIDDLE.");
        }
        else if (digit != 0 && letter != 0 && other != 0)
        {
            Console.WriteLine("Congrats! The password you entered is STRONG.");
        }
    }
}

