using System;
using System.Windows.Forms;

namespace Lab_3
{
  partial class About : Form
  {
    public About()
    {
      TopMost = true;
      InitializeComponent();
      checkBox.Checked = !Properties.Settings.Default.ShowAbout;
    }
    private void checkAbout_CheckedChanged(object sender, EventArgs e)
    {
      if (checkBox.Checked)
        Properties.Settings.Default.ShowAbout = false;
      else
        Properties.Settings.Default.ShowAbout = true;
    }
  }
}
