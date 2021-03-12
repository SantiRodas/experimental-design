using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Experiment.Model;

namespace Tests
{
    [TestClass]
    public class UnitTest1
    {
        public const int LowLimit = 10;
        public const int HighLimit = 10000;

        private int limit;
        private int backwards;
        private int[] arrayTest;

        private int[] solutionLow;
        private int[] solutionHigh;

        [TestInitialize]
        public void Initialize() 
        {
            solutionLow = new int[LowLimit];
            solutionHigh = new int[HighLimit];

            for (int i = 0; i < LowLimit; i++)
            {
                solutionLow[i] = i+1; 
            }

            for (int i = 0; i < HighLimit; i++)
            {
                solutionHigh[i] = i+1;
            }
        }
        private void SetUp1(bool high)
        {
            if (high)
            {
                limit = HighLimit;
                backwards = HighLimit;
            }
            else
            {

                limit = LowLimit;
                backwards = LowLimit;
            }

            arrayTest = new int[limit];

            for (int i = 0; i< limit; i++) {
                arrayTest[i] = backwards;
                backwards--;
            }
        }


        private void SetUp2(bool high)
        {
           
            if (high)
            {
                limit = HighLimit;
            }
            else
            {
                limit = LowLimit;
            }


            arrayTest = new int[limit];
            var random = new Random();

            for (int i = 0; i < limit; i++)
            {
                 
                arrayTest[i] = random.Next();
               
            }
        }

        private void SetUp3(bool high)
        {
            SetUp1(high);

            arrayTest[8] = 4;
            arrayTest[2] = 4;

        }



        [TestMethod]
        public void TestLowBubble()
        {
            SetUp1(false);
            SortAlgorithms.BubbleSort(arrayTest);

            bool same = true;

            for (int i = 0; i < arrayTest.Length && same; i++) 
            {
                if (arrayTest[i] != solutionLow[i]) 
                {
                    same = false;
                }
            }

            Assert.IsTrue(same);
         

        }

        [TestMethod]
        public void TestLowInsertion()
        {
            SetUp1(false);
            SortAlgorithms.InsertionSort(arrayTest);

            bool same = true;

            for (int i = 0; i < arrayTest.Length && same; i++)
            {
                if (arrayTest[i] != solutionLow[i])
                {
                    same = false;
                }
            }

            Assert.IsTrue(same);


        }

        [TestMethod]
        public void TestLowRandomInsertion()
        {
            SetUp2(false);
            SortAlgorithms.InsertionSort(arrayTest);

            bool same = true;

            for (int i = 0; i < arrayTest.Length && same && (i+1 < arrayTest.Length); i++)
            {
                if (arrayTest[i] > arrayTest[i+1])
                {
                    same = false;
                }
            }

            Assert.IsTrue(same);


        }



        [TestMethod]
        public void TestLowRandomBubble()
        {
            SetUp2(false);
            SortAlgorithms.BubbleSort(arrayTest);

            bool same = true;

            for (int i = 0; i < arrayTest.Length && same && (i + 1 < arrayTest.Length); i++)
            {
                if (arrayTest[i] > arrayTest[i + 1])
                {
                    same = false;
                }
            }

            Assert.IsTrue(same);


        }


        //High Tests

        [TestMethod]
        public void TestHighBubble()
        {
            SetUp1(true);
            SortAlgorithms.BubbleSort(arrayTest);

            bool same = true;

            for (int i = 0; i < arrayTest.Length && same; i++)
            {
                if (arrayTest[i] != solutionHigh[i])
                {
                    same = false;
                }
            }

            Assert.IsTrue(same);


        }

        [TestMethod]
        public void TestHighInsertion()
        {
            SetUp1(true);
            SortAlgorithms.InsertionSort(arrayTest);

            bool same = true;

            for (int i = 0; i < arrayTest.Length && same; i++)
            {
                if (arrayTest[i] != solutionHigh[i])
                {
                    same = false;
                }
            }

            Assert.IsTrue(same);


        }

        [TestMethod]
        public void TestHighInsertionBubble()
        {
            SetUp2(true);
            SortAlgorithms.InsertionSort(arrayTest);

            bool same = true;

            for (int i = 0; i < arrayTest.Length && same && (i + 1 < arrayTest.Length); i++)
            {
                if (arrayTest[i] > arrayTest[i + 1])
                {
                    same = false;
                }
            }

            Assert.IsTrue(same);


        }



        [TestMethod]
        public void TestHighRandomBubble()
        {
            SetUp2(true);
            SortAlgorithms.BubbleSort(arrayTest);

            bool same = true;

            for (int i = 0; i < arrayTest.Length && same && (i + 1 < arrayTest.Length); i++)
            {
                if (arrayTest[i] > arrayTest[i + 1])
                {
                    same = false;
                }
            }

            Assert.IsTrue(same);


        }


        //Same value on some point

        [TestMethod]
        public void TestLowRepBubble()
        {
            SetUp3(false);
            SortAlgorithms.BubbleSort(arrayTest);

            bool same = true;

            for (int i = 0; i < arrayTest.Length && same && (i + 1 < arrayTest.Length); i++)
            {
                if (arrayTest[i] > arrayTest[i + 1])
                {
                    same = false;
                }
            }

            Assert.IsTrue(same);


        }


        [TestMethod]
        public void TestLowRepInsertion()
        {
            SetUp3(false);
            SortAlgorithms.InsertionSort(arrayTest);

            bool same = true;

            for (int i = 0; i < arrayTest.Length && same && (i + 1 < arrayTest.Length); i++)
            {
                if (arrayTest[i] > arrayTest[i + 1])
                {
                    same = false;
                }
            }

            Assert.IsTrue(same);


        }


        [TestMethod]
        public void TestHighRepBubble()
        {
            SetUp3(true);
            SortAlgorithms.BubbleSort(arrayTest);

            bool same = true;

            for (int i = 0; i < arrayTest.Length && same && (i + 1 < arrayTest.Length); i++)
            {
                if (arrayTest[i] > arrayTest[i + 1])
                {
                    same = false;
                }
            }

            Assert.IsTrue(same);


        }


        [TestMethod]
        public void TestHighRepInsertion()
        {
            SetUp3(true);
            SortAlgorithms.InsertionSort(arrayTest);

            bool same = true;

            for (int i = 0; i < arrayTest.Length && same && (i + 1 < arrayTest.Length); i++)
            {
                if (arrayTest[i] > arrayTest[i + 1])
                {
                    same = false;
                }
            }

            Assert.IsTrue(same);


        }


    }
}
