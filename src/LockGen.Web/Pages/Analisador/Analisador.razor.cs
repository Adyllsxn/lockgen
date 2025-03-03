namespace LockGen.Web.Pages.Analisador;
public partial class AnalisadorRazor : ComponentBase
{
    
    #region </Proprieties>
        public int passwordLength = 12;
        public string generatedPassword = "";
        public string copyMessage = "";
    #endregion

    #region </Services>
        [Inject]
        public IJSRuntime JS { get; set; } = null!;
    #endregion
    
    #region </Methods>
        public async Task CopyToClipboard()
        {
            if (!string.IsNullOrEmpty(generatedPassword))
            {
                await JS.InvokeVoidAsync("copyToClipboard", generatedPassword);
                copyMessage = "✅ Senha copiada!";
            }
        }

        public void GeneratePassword()
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()-_=+";
            Random random = new();
            char[] passwordArray = new char[passwordLength];

            for (int i = 0; i < passwordLength; i++)
            {
                passwordArray[i] = chars[random.Next(chars.Length)];
            }

            generatedPassword = new string(passwordArray);
            copyMessage = ""; // Limpa a mensagem ao gerar uma nova senha
        }
    #endregion
}
