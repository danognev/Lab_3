using System;
using System.IO;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Excel = Microsoft.Office.Interop.Excel;

namespace Lab_3
{
  static class Files
  {
    public static string FileName { get; set; }
    private const int ParamsValue = 4;
    private enum ParamsType { a = 1, xstart, xend, step };
    public static void SaveResultFile(SaveFileDialog SaveDialog, Chart Graph) {
      const string TMP_PIC_NAME = "tmp.png";
      const int DATA_CELL_START = 2, X_CELL = 2, Y_CELL = 3, PARAMS_CELL = 1;
      const float LEFT = 0, TOP = 50, WIDTH = 350, HEIGHT = 300;
      try
      {
        Excel.Application App = new Excel.Application();
        object MissValue = System.Reflection.Missing.Value;
        Excel.Workbook WrkBk = App.Workbooks.Add(MissValue);
        Excel.Worksheet WrkSh = (Excel.Worksheet)WrkBk.Worksheets.get_Item(1);
        FileName = SaveDialog.FileName;
        WrkSh.Cells[PARAMS_CELL, 1] = "Xstart = " + Algorithm.XStart; 
        WrkSh.Cells[PARAMS_CELL, 2] = "Xend = " + Algorithm.XEnd; 
        WrkSh.Cells[PARAMS_CELL, 3] = "Xstep = " + Algorithm.Step; 
        WrkSh.Cells[PARAMS_CELL, 4] = "A = " + Algorithm.A; 
        WrkSh.Cells[X_CELL, 1] = "X";
        WrkSh.Cells[Y_CELL, 1] = "Y";
        for (int i = 0; i < Algorithm.X1.Count; i++)
        {
          WrkSh.Cells[X_CELL, i + DATA_CELL_START] = Algorithm.X1[i];
          WrkSh.Cells[Y_CELL, i + DATA_CELL_START] = Algorithm.Yp[i];
        }
        for (int i = Algorithm.X1.Count; i < Algorithm.X1.Count + Algorithm.X2.Count; i++)
        {
          WrkSh.Cells[X_CELL, i + DATA_CELL_START] = Algorithm.X1[i - Algorithm.X1.Count];
          WrkSh.Cells[Y_CELL, i + DATA_CELL_START] = Algorithm.Yp[i - Algorithm.X1.Count];
        }
        Graph.SaveImage(TMP_PIC_NAME, ChartImageFormat.Png);
        string path = Path.GetFullPath(TMP_PIC_NAME);
        File.SetAttributes(path, FileAttributes.Hidden);
        WrkSh.Shapes.AddPicture(path, Microsoft.Office.Core.MsoTriState.msoFalse, Microsoft.Office.Core.MsoTriState.msoCTrue,
        LEFT, TOP, WIDTH, HEIGHT);
        File.Delete(path);
        WrkBk.SaveAs(FileName, Excel.XlFileFormat.xlWorkbookNormal, MissValue, MissValue, MissValue, MissValue, Excel.XlSaveAsAccessMode.xlExclusive
        , MissValue, MissValue, MissValue, MissValue, MissValue);
        WrkBk.Close(true, MissValue, MissValue);
        App.Quit();
        System.Runtime.InteropServices.Marshal.ReleaseComObject(App);
        System.Runtime.InteropServices.Marshal.ReleaseComObject(WrkBk);
        System.Runtime.InteropServices.Marshal.ReleaseComObject(WrkSh);
        GC.Collect();
        MessageBox.Show("Сохранение результата успешно выполнено!", "Успешно");
      }
      catch(Exception ex) {
        MessageBox.Show(ex.Message, "Произошла ошибка!");
      }
    }
    public static void SaveFile(SaveFileDialog SaveDialog, string text) {
      FileName = SaveDialog.FileName;
      try
      {
        using (StreamWriter file = new StreamWriter(FileName, false))
        {
          file.Write(text);
          file.Close();
        }
        MessageBox.Show("Сохранение выполнено!");
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.Message);
      }
    }
    public static void OpenFile(OpenFileDialog OpenDialog) {
      FileName = OpenDialog.FileName;
      int count = 0;
        using (StreamReader rfile = new StreamReader(FileName))
        {
          double value;
          string input = rfile.ReadLine();
          string[] numbers = input.Split('|');
          foreach(string number in numbers) {
            if(!double.TryParse(number,out value)) {
              throw new Exception("Невозможно получить данные из файла " + FileName);
            }
            else {
              count++;
              switch(count) {
                case (int)ParamsType.a: {
                    Algorithm.A = value;
                    break;
                  }
                case (int)ParamsType.xstart:
                  {
                    Algorithm.XStart = value;
                    break;
                  }
                case (int)ParamsType.xend:
                  {
                    Algorithm.XEnd = value;
                    break;
                  }
                case (int)ParamsType.step:
                  {
                    Algorithm.Step = value;
                    break;
                  }
              }
            }
          }
          if (count != ParamsValue)
            throw new Exception("Некорректные данные в файле " + FileName);
          else
          {
            MessageBox.Show("Успешно загружено!");
          }
        }
    }
  }
}
