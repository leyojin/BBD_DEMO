using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD.StepDefinitions
{
    [Binding]
    internal class Feature1
    {
        [Given(@"open chrome")]
        public void GivenOpenChrome()
        {
            Console.WriteLine("A");
        }

        [Given(@"B")]
        public void GivenB()
        {
            Console.WriteLine("B");
        }

        [When(@"C")]
        public void WhenC()
        {
            Console.WriteLine("C");
        }

        [Then(@"D")]
        public void ThenD()
        {
            Console.WriteLine("D");
        }

    }
}
