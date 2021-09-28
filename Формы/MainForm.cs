using System;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using System.Collections.Generic;

namespace Lab_3
{
  public partial class MainForm : Form
  {
    private const int TEXT_NUM = 2;
    private Label[] text = new Label[TEXT_NUM];
    private List<double> Default = new List<double>();
    public MainForm()
    {
      InitializeComponent();
    }

    private void MainForm_Load(object sender, EventArgs e)
    {
      for (int i = 0; i < TEXT_NUM; i++)
      {
        text[i] = new Label();
        text[i].AutoSize = true;
        text[i].BackColor = Color.Transparent;
        text[i].Font = new Font(text[i].Font.FontFamily, 14, FontStyle.Regular);
      }
      text[0].Text = "X";
      text[1].Text = "Y";
      Default.Add(0);
      SetXY();
      graph.Series["Series1"].Points.DataBindXY(Default, Default);
    }
    private void ClearBtn_Click(object sender, EventArgs e)
    {
      graph.Series["Series1"].Points.Clear();
      graph.Series["Series1"].Points.DataBindXY(Default, Default);
      graph.Series["Series2"].Points.Clear();
      statusLabel.Text = "Введите значения для построения графика";
      table.Visible = false;
      результатToolStripMenuItem.Enabled = false;
    }
    private void BtnDraw_Click(object sender, EventArgs e)
    {
      try
      {
        table.Controls.Clear();
        Algorithm.X1.Clear();
        Algorithm.X2.Clear();
        Algorithm.Yp.Clear();
        Algorithm.Yn.Clear();
        SetXY();
        graph.Series["Series1"].Points.Clear();
        graph.Series["Series2"].Points.Clear();
        graph.Series["Series1"].Points.DataBindXY(Default, Default);
        table.Visible = false;
        Algorithm.A = (double)Abox.Value;
        Algorithm.XStart = (double)Xstart.Value;
        Algorithm.XEnd = (double)Xend.Value;
        Algorithm.Step = (double)StepBox.Value;
        Algorithm.CreateGraph();
        int size = Algorithm.X1.Count + Algorithm.X2.Count;
        Label[] coordX = new Label[size];
        Label[] coordY = new Label[size];
        for (int i = 0; i < size; i++)
        {
          coordX[i] = new Label();
          coordY[i] = new Label();
          coordX[i].BackColor = Color.Transparent;
          coordX[i].Font = new Font(coordX[i].Font.FontFamily, 14, FontStyle.Regular);
          coordY[i].BackColor = Color.Transparent;
          coordY[i].Font = new Font(coordY[i].Font.FontFamily, 14, FontStyle.Regular);
        }
        for (int i = 0; i < Algorithm.X1.Count; i++)
        {
          coordX[i].Text = Math.Round(Algorithm.X1[i], 2).ToString();
          coordY[i].Text = Math.Round(Algorithm.Yp[i], 2).ToString();
        }
        for (int i = Algorithm.X1.Count; i < size; i++)
        {
          coordX[i].Text = Math.Round(Algorithm.X2[i - Algorithm.X1.Count], 2).ToString();
          coordY[i].Text = Math.Round(Algorithm.Yn[i - Algorithm.X1.Count], 2).ToString();
        }
        graph.Series["Series1"].Points.DataBindXY(Algorithm.X1, Algorithm.Yp);
        graph.Series["Series2"].Points.DataBindXY(Algorithm.X2, Algorithm.Yn);
        table.ColumnCount = size + 1;
        for (int i = 0; i < size; i++)
        {
          table.Controls.Add(coordX[i], i+1, 0);
          table.Controls.Add(coordY[i], i+1, 1);
        }
        table.Visible = true;
        statusLabel.Text = "График успешно построен!";
        результатToolStripMenuItem.Enabled = true;
      }
      catch (Exception ex)
      {
        SystemSounds.Asterisk.Play();
        MessageBox.Show(this, ex.Message, "Ошибка!");
        statusLabel.Text = "В процессе построения возникла ошибка!";
        результатToolStripMenuItem.Enabled = false;
      }
    }
    private void SetXY() {
      table.Controls.Add(text[0], 0, 0);
      table.Controls.Add(text[1], 0, 1);
    }
    public void SetParams() {
      Abox.Value = (decimal)Algorithm.A;
      Xstart.Value = (decimal)Algorithm.XStart;
      Xend.Value = (decimal)Algorithm.XEnd;
      StepBox.Value = (decimal)Algorithm.Step;
    }
    private void ИнформацияToolStripMenuItem_Click(object sender, EventArgs e)
    {
      SystemSounds.Asterisk.Play();
      About form = new About();
      form.Show(this);
    }

    private void ЗагрузитьToolStripMenuItem_Click(object sender, EventArgs e)
    {
      openFileDialog.ShowDialog();
    }

    private void SaveFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
    {
      string text = Abox.Value.ToString() + "|" + Xstart.Value.ToString() + "|" + Xend.Value.ToString() +
      "|" + StepBox.Value.ToString();
      Files.SaveFile(saveFileDialog, text);
    }

    private void OpenFileDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
    {
      try
      {
        Files.OpenFile(openFileDialog);
        SetParams();
      }
      catch (Exception ex)
      {
        MessageBox.Show(this, ex.Message, "Ошибка!");
      }
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
      Properties.Settings.Default.Save();
    }

    private void исходныеДанныеToolStripMenuItem_Click(object sender, EventArgs e)
    {
      saveFileDialog.ShowDialog();
    }

    private void результатToolStripMenuItem_Click(object sender, EventArgs e)
    {
      saveFileResultDialog.ShowDialog();
    }

    private void saveFileResultDialog_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
    {
      Files.SaveResultFile(saveFileResultDialog,graph);
    }
  }
}
