namespace git_pra
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
            Application.Run(new Form1());

        }
        public static string Action()
        {
            return "1123";
        }
        public static string Program2(string name)
        {
            return name;
        }
        public static string test()
        {
            return "test";
        }
    }
}