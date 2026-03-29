namespace calc
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            var form = new Form1();
            //form..comboBox2.Items.AddRange(new object[] { "1", "3", "4" });
            Application.Run(form);
        }
    }
}