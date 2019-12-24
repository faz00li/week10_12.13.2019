using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetSpeak;
using System;

namespace LeetSpeak.Tests
{
  [TestClass]
  public class TranslatorTest
  {
    Translator t = new Translator();

    [TestMethod]
    public void Translate_ABecomesFour()
    {
      Assert.AreEqual("4", t.Translate("a"));
    }

    [TestMethod]
    public void Translate_BBecomesEight()
    {
      Assert.AreEqual("8", t.Translate("b"));
    }

    [TestMethod]
    public void Translate_CBecomesAlligator()
    {
      Assert.AreEqual("<", t.Translate("C"));
    }

    [TestMethod]
    public void Translate_EBecomesThree()
    {
      Assert.AreEqual("3", t.Translate("e"));
    }

    [TestMethod]
    public void Translate_baceBecomes84Alligator3()
    {
      Console.WriteLine("here");
      Assert.AreEqual("84<3", t.Translate("bace"));
    }
  }
}
