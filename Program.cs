using System;
using System.Windows.Forms;

namespace Lab_3
{
  static class Program
  {
    [STAThread]
    static void Main()
    {
      Application.EnableVisualStyles();
      Application.SetCompatibleTextRenderingDefault(false);
      if(Properties.Settings.Default.ShowAbout) {
        About form = new About();
        form.Show();
      }
      Application.Run(new MainForm());
    }
  }
}
