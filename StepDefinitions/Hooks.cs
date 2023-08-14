using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDD.StepDefinitions
{
    [Binding]
    internal class Hooks
    {
        [BeforeScenario]
        public void setup()
        {
            Console.Write("BEfore Scenario");
        }
        [AfterScenario]
        public void teardown()
        {
            Console.Write("After Scenario");
        }
        [BeforeFeature]
        public void setup1()
        {
            Console.Write("BEfore feature");
        }
        [AfterFeature]
        public void teardown1()
        {
            Console.Write("After Feature");
        }
        [BeforeScenario("CategoryA")]
        public void setup2()
        {
            Console.WriteLine("Before scenario of category A");
        }
    }
}
