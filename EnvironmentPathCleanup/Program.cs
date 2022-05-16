namespace EnvironmentPathCleanup
{
  internal static class Program
  {
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {

      //var t = new Scratch<Controllers.MainFormController>();

      //var n = t.GetPropertyName(x => x.CanSave);

      //n = t.GetPropertyName(x => x.Delme );



      // To customize application configuration such as set high DPI settings or default font,
      // see https://aka.ms/applicationconfiguration.
      ApplicationConfiguration.Initialize();
      Application.Run(new Forms.MainForm());
    }
  }
}