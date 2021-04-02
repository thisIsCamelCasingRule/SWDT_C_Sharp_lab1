using Microsoft.VisualStudio.TestTools.UnitTesting;
using HomeworkLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkLibrary.Tests
{
    [TestClass()]
    public class StringManagerTests
    {
        [TestMethod()]
        public void GetIntegersFromListTest1()
        {
            //arange
            List<object> input = new List<object>() { 1, 2, 'a', 'b' };
            List<int> expected = new List<int>() { 1, 2 };
            
            //act
            StringManager s = new StringManager();
            List<int> actual = StringManager.GetIntegersFromList(input);

            //asert
            for (int i = 0; i < actual.Count; i++) {
                Assert.AreEqual(expected[i], actual[i]);
            }

            Assert.AreEqual(expected.Count, actual.Count);
        }

        [TestMethod()]
        public void GetIntegersFromListTest2()
        {
            //arange
            List<object> input = new List<object>() {};
            
            //act
            List<int> actual = StringManager.GetIntegersFromList(input);

            //asert
            Assert.IsNull(actual);
        }

        [TestMethod()]
        public void first_non_repeating_letterTest1()
        {
            //arange
            String input = "sTreSs";
            String expected = "T";
            
            //act
            String actual = StringManager.first_non_repeating_letter(input);
            
            //asert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void first_non_repeating_letterTest2()
        {
            //arange
            String input = " a ";
            String expected = "a";
            
            //act
            String actual = StringManager.first_non_repeating_letter(input);
            
            //asert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void digital_rootTest1()
        {
            //arange
            int input = 128;
            int expected = 2;
           
            //act
            int actual = StringManager.digital_root(input);
            
            //asert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void digital_rootTest2()
        {
            //arange
            int input = 1;
            int expected = 1;
            
            //act
            int actual = StringManager.digital_root(input);
           
            //asert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void pairs_targetTest1()
        {
            //arange
            int[] input = { 1, 3, 6, 2, 2, 0, 4, 5 };
            int target = 5;
            int expected = 4;
            
            //act
            int actual = StringManager.pairs_target(input, target);
           
            //asert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void pairs_targetTest2()
        {
            //arange
            int[] input = null;
            int target = 5;
            int expected = 0;

            //act
            int actual = StringManager.pairs_target(input, target);
            //asert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void guestListRefactorTest1()
        {
            //arange
            String input = "Fred:Corwill; Wilfred:Corwill ;Barney:TornBull;Betty:Tornbull;Bjon:Tornbull;Raphael:Corwill;Alfred:Corwill";
            String expected = "(CORWILL, ALFRED)(CORWILL, FRED)(CORWILL, RAPHAEL)(CORWILL, WILFRED)(TORNBULL, BARNEY)(TORNBULL, BETTY)(TORNBULL, BJON)";

            //act
            String actual = StringManager.guestListRefactor(input);

            //asert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void guestListRefactorTest2()
        {
            //arange
            String input = "";
            String expected = null;

            //act
            String actual = StringManager.guestListRefactor(input);

            //asert
            Assert.AreEqual(expected, actual);
        }
    }
}