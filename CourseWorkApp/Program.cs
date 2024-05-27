using CourseWorkApp.View;
namespace CourseWorkApp
{
    internal static class Program
    {
        const long passwordHash = 73973732; // "linkedList"
        [STAThread]
        static void Main()
        {
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
                        MessageBox.Show("Ïàğîëü ââåäåí íåâåğíî!", "Îøèáêà âõîäà", MessageBoxButtons.OK, MessageBoxIcon.Error);
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