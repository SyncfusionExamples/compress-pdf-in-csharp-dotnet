namespace WinForms;

static class Program
{
    [STAThread]
    static void Main()
    {
#if NET462
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
#else
        ApplicationConfiguration.Initialize();
#endif
        Application.Run(new Form1());
    }
}
