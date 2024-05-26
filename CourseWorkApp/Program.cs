using CourseWorkApp.View;
namespace CourseWorkApp
{
    internal static class Program
    {
        const long passwordHash = 73973732; // "linkedList"
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var a = "sdsd".ToCharArray().GetHashCode();
            loginForm loginForm = new loginForm();
            switch (loginForm.ShowDialog())
            {
                case DialogResult.OK:

                    if (PassHashFunc(loginForm.passTextBox.Text.ToString())== passwordHash)
                        Application.Run(new MainForm());
                    else
                    {
                        MessageBox.Show("Пароль введен неверно!", "Ошибка входа", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                default:
                    break;
            }
            
        }
        static private long PassHashFunc(string arg)
        {
            long sum = 0;

            foreach (char c in arg)
            {
                sum += c * 256;
            }
            return ((sum * sum) >> (int)(sum % 21)) * 17;
        }
    }
}