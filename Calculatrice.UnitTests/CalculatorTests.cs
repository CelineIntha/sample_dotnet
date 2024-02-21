using Calculatrice;
namespace Calculatrice.UnitTests;

[TestClass]

public class UnitTest1
{
    // Test Initialize
    private Calculator _calculator;

    [TestInitialize]
    public void Init()
    {
        _calculator = new Calculator();
    }

    [TestMethod]
    // Le test va s'executer 3 fois
    [DataRow(10, 5, 15)] // 15 = résultat attendu
    [DataRow(999, 1, 1000)] 
    [DataRow(1, 500, 501)] 
    public void Addtest(int numberOne, int numberTwo, int expectedResult)
    {;

        var actualResult = _calculator.Add(numberOne, numberTwo);

        Assert.AreEqual(expectedResult, actualResult);
    }

    [TestMethod]
    public void Substract_WithTwoNumbers_ReturnsSubstraction()
    {
        Assert.AreEqual(1, _calculator.Substract(3, 2));
    }

    [TestMethod]
    public void Multest()
    {
        Assert.AreEqual(8, _calculator.Multiply(4, 2));
    }

    [TestMethod]
    public void Divide_WithTwoStrictlyPositiveNumbers_ReturnsDivision()
    {
        Assert.AreEqual(2, _calculator.Divide(4, 2));
    }

    [TestMethod]
    public void Add_WithTwoNumbers_ReturnsAddition()
    {
        var calculator = new Calculator();

        var result = calculator.Add(10, 5);

        Assert.AreEqual(15, result);
    }
}