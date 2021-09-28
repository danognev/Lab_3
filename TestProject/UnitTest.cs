using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lab_3;

namespace TestProject
{
  [TestClass]
  public class UnitTest
  {
    [TestMethod]
    public void TestMethod()
    {
      double Y1_Expected = -0.5925925925925926, 
      Y2_Expected = 0.5925925925925926, X_Expected = 0;
      Algorithm.A = 0.5;
      Algorithm.XStart = 0;
      Algorithm.XEnd = 0;
      Algorithm.Step = 0.2;
      Algorithm.CreateGraph();
      Assert.AreEqual(Y1_Expected, Algorithm.Yn[0]);
      Assert.AreEqual(Y2_Expected, Algorithm.Yp[0]);
      Assert.AreEqual(X_Expected, Algorithm.X1[0]);
    }
  }
}
