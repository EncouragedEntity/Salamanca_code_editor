using SourceCodeEditor.AppearenceConfig;

namespace SourceCodeEditor
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            MainForm mainForm = new MainForm();
            Application.Run(mainForm);
        }
    }
}