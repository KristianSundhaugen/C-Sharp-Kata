using System;
using System.Linq;
using NUnit.Framework;


[TestFixture]
public class KataTestf
{
    [Test]
    public void _0_BasicTests()
    {
        var kata = new Kata();

        Assert.AreEqual(321, kata.ReverseNumber(123));
        Assert.AreEqual(-321, kata.ReverseNumber(-123));
        Assert.AreEqual(0, kata.ReverseNumber(0));
    }
}