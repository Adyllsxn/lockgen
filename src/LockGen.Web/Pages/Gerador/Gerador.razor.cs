namespace LockGen.Web.Pages.Gerador;
public partial class GeradorRazor : ComponentBase
{
    private int passwordLength = 12;
        private bool useUppercase = true;
        private bool useDigits = true;
        private bool useSpecial = true;
        private string password = "";
        private string passwordStrength = "";
        private string strengthColor = "black";

        private void GeneratePassword()
        {
            password = PasswordGenerator.Generate(passwordLength, useUppercase, useDigits, useSpecial);
            passwordStrength = PasswordStrengthChecker.GetStrength(password);
            strengthColor = passwordStrength switch
            {
                "Muito Fraca" => "red",
                "Fraca" => "orange",
                "Razoável" => "yellow",
                "Forte" => "lightgreen",
                _ => "green"
            };
        }

        private void CopyToClipboard()
        {
            ClipboardService.CopyToClipboard(password);
        }
    }

    public static class ClipboardService
    {
        private static string clipboardContent = "";

        public static void CopyToClipboard(string text)
        {
            clipboardContent = text;
        }

        public static string GetClipboardContent()
        {
            return clipboardContent;
        }
    }

    public static class PasswordGenerator
    {
        private static readonly Random random = new();
        private const string Uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        private const string Lowercase = "abcdefghijklmnopqrstuvwxyz";
        private const string Digits = "0123456789";
        private const string SpecialChars = "!@#$%^&*()_+[]{}|;:,.<>?";

        public static string Generate(int length, bool useUppercase, bool useDigits, bool useSpecial)
        {
            if (length < 4) length = 4;
            var charSet = Lowercase + (useUppercase ? Uppercase : "") + (useDigits ? Digits : "") + (useSpecial ? SpecialChars : "");
            return new string(Enumerable.Repeat(charSet, length).Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }

    public static class PasswordStrengthChecker
    {
        public static string GetStrength(string password)
        {
            int score = 0;
            if (password.Length >= 8) score++;
            if (password.Any(char.IsUpper)) score++;
            if (password.Any(char.IsDigit)) score++;
            if (password.Any(c => "!@#$%^&*()_+[]{}|;:,.<>?".Contains(c))) score++;

            return score switch
            {
                0 or 1 => "Muito Fraca",
                2 => "Fraca",
                3 => "Razoável",
                4 => "Forte",
                _ => "Muito Forte"
            };
        }    
}
