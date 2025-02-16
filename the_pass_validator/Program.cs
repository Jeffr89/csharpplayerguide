while (true)
{
    Console.WriteLine("Write a password: ");
    string input = Console.ReadLine();

    if (PasswordValidator.Validate(input)) Console.WriteLine("Your password is allowed!");
    else Console.WriteLine("Your password is not allowed");
}




public static class PasswordValidator
{

    public static bool Validate(string password)
    {
        int upperCaseLetter = 0;
        int lowerCaseLetter = 0;
        int number = 0;

        if (password.Length > 13) return false;
        if (password.Length < 6) return false;

        foreach (char letter in password)
        {
            if ((letter == 'T') || (letter == '&')) return false;
            else if (char.IsUpper(letter)) upperCaseLetter++;
            else if (char.IsLower(letter)) lowerCaseLetter++;
            else if (char.IsDigit(letter)) number++;
        }

        if ((upperCaseLetter > 0) && (lowerCaseLetter > 0) && (number > 0)) return true;
        else return false;
    }

}

