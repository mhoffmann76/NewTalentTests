using System.Runtime.InteropServices;
using NewTalents;
using NuGet.Frameworks;

namespace NewTalentTests;


public class UnitTest1
{
    [Fact]

    public void TestSomar()
    {
        Calculadora calc = new Calculadora();
        int resultado = calc.Somar(1, 2);
        Assert.Equal(3, resultado);

    }

    [Fact]
    public void TestMultiplicar()
    {
        Calculadora calc = new Calculadora();
        int resultado = calc.Multiplicar(1, 2);
        Assert.Equal(2, resultado);

    }

    [Fact]
    public void TestDividir()
    {
        Calculadora calc = new Calculadora();
        int resultado = calc.Dividir(1, 1);
        Assert.Equal(1, resultado);

    }

    [Fact]
    public void Subtrair()
    {
        Calculadora calc = new Calculadora();
        int resultado = calc.Subtrair(3, 1);
        Assert.Equal(2, resultado);

    }

}