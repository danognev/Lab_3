using System;
using System.Collections.Generic;
using static System.Math;

namespace Lab_3
{
  static public class Algorithm
  {
    #region
    static private List<double> x1 = new List<double>();
    static private List<double> x2 = new List<double>();
    static private List<double> yp = new List<double>();
    static private List<double> yn = new List<double>();
    static public List<double> X1 { get { return x1; } set { x1 = value; } }
    static public List<double> X2 { get { return x2; } set { x2 = value; } }
    static public List<double> Yp { get { return yp; } set { yp = value; } }
    static public List<double> Yn { get { return yn; } set { yn = value; } }
    static public double A { get; set; }
    static public double XStart { get; set; }
    static public double XEnd { get; set; }
    static public double Step { get; set; }
    #endregion
    static public void CreateGraph()
    {
      if (Step == 0.0 || A == 0.0)
      {
        throw new Exception("Шаг или 'a' не может быть равен нулю!");
      }
      else
      {
        double tmp = XStart;
        double result;
        while (tmp <= XEnd)
        {
          result = ((A - tmp) * Pow(8 * A + tmp, 2)) / (27 * A);
          X1.Add(tmp);
          Yp.Add(result);
          X2.Add(tmp);
          Yn.Add(-result);
          tmp += Step;
        }
      }
    }
  }
}
