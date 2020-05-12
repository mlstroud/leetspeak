using Microsoft.VisualStudio.TestTools.UnitTesting;
using Leetspeak;

namespace Leetspeak.TestTools
{
  [TestClass]
  public class TranslatorTests
  {
    [TestMethod]
    public void Translate_ReturnsInputAsString()
    {
      Assert.AreEqual("banana", Translator.Translate("banana"));
    }

    [TestMethod]
    public void Translate_ReplacesEWith3()
    {
      Assert.AreEqual("s33", Translator.Translate("see"));
    }

    [TestMethod]
    public void Translate_ReplacesOWith0()
    {
      Assert.AreEqual("h3ll0", Translator.Translate("hello"));
    }

    [TestMethod]
    public void Translate_ReplacesIWith1()
    {
      Assert.AreEqual("1gl00", Translator.Translate("Igloo"));
    }

    [TestMethod]
    public void Translate_ReplacesTWith7()
    {
      Assert.AreEqual("D0n'7", Translator.Translate("Don't"));
    }

    [TestMethod]
    public void Translate_ReplacesSWithZ()
    {
      Assert.AreEqual("3x3rciz3z", Translator.Translate("Exercizes"));
    }
  }
}