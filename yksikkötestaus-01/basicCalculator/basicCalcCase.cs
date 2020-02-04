using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace basicCalculator
{
    [TestFixture]
    class basicCalcCase
    {
        [TestCase]

    public void Add()
        {
            basicCalc math = new basicCalc();
            Assert.AreEqual(25, math.Add(20, 5));
        }

        [TestCase]
    public void Sub()
        {
            basicCalc math = new basicCalc();
            Assert.AreEqual(25, math.Sub(30, 5));
        }

        [TestCase]
    public void Mul()
        {
            basicCalc math = new basicCalc();
            Assert.AreEqual(25, math.Mul(5, 5));
        }

        [TestCase]
    public void Div()
        {
            basicCalc math = new basicCalc();
            Assert.AreEqual(25, math.Div(100, 4));
        }

        [TestCase]
    public void Jak()
        {
            basicCalc math = new basicCalc();
            Assert.AreEqual(0, math.Jak(5, 5));
        }
    }
}
