namespace MoneyExtension.Tests;

[TestClass]
public class MoneyExtensionTests
{
    [TestMethod]
    public void ShouldConvertDecimalToInt()
    {
        decimal valor = 279.78M;
        var cents = valor.ToCents();

        Assert.AreEqual(27978, cents);
    }
}