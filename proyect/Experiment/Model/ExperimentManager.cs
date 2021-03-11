using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace Experiment.Model
{
    class ExperimentManager
    {
        // -----------------------------------------------------------------------------------------

        // Fields and properties

        private string[] _lastExpResults; //Comma separated values [0] are headers

        private readonly Random _ranNumGen;

        private int _experimentId;

        public string[] LastExpResults
        {
            get
            {
                return _lastExpResults;
            }

        }
        // -----------------------------------------------------------------------------------------

        // Constructor method of the class Controller

        public ExperimentManager()
        {
            _ranNumGen = new Random();
            _experimentId = 0;
        }

        // -----------------------------------------------------------------------------------------

        // Principal method of the proyect Experiment
        // Modify in case a progress bar wants to be added in user interface
        public bool StartExperiment(int arraySize, int rep, Order order)
        {
            Stopwatch sw = new Stopwatch();

            _lastExpResults = new string[rep + 1];
            _lastExpResults[0] = "repetition,size,order,bubbleTime(ms),selectionTime(ms)";

            for (int i = 0; i < rep; i++)
            {
                List<int[]> arrays;
              
                if (order == Order.Random)
                {
                    arrays = InitRandomArrays(arraySize);
                }
                else if (order == Order.Increasing)
                {
                    arrays = InitOrderedArrays(arraySize, true);
                }
                else
                {
                    arrays = InitOrderedArrays(arraySize, false);
                }

                int[] numArrayBubble = arrays[0];
                int[] numArrayInsertion = arrays[0];

                sw.Start();

                SortAlgorithms.BubbleSort(numArrayBubble);

                sw.Stop();

                long bubbleTime = sw.ElapsedMilliseconds;

                sw.Reset();
                sw.Start();

                SortAlgorithms.InsertionSort(numArrayInsertion);

                sw.Stop();

                long insertionTime = sw.ElapsedMilliseconds;
                sw.Reset();

                _lastExpResults[rep+1] = (rep + 1) + "," + arraySize + "," + order + "," + bubbleTime + "," + insertionTime;

            }
            return true;
        }

        // -----------------------------------------------------------------------------------------

        private List<int[]> InitRandomArrays(int size)
        {
            int[] numArray1 = new int[size];
            int[] numArray2 = new int[size];
            
            for (int i = 0; i < size; i++)
            {
                int randNum = ((_ranNumGen.Next(0, 1) > 0.5) ? 1 : -1) * _ranNumGen.Next();
                numArray1[i] = randNum;
                numArray2[i] = randNum;
            }

            List<int[]> list = new List<int[]>();

            list.Add(numArray1);
            list.Add(numArray2);

            return list;
        }

        //
        //Suppose that size is more than 1
        private List<int[]> InitOrderedArrays(int size, bool increasing)
        {
            int[] numArray1 = new int[size];
            int[] numArray2 = new int[size];

            if (increasing)
            {
                for (int i = 0; i < size; i++)
                {
                    numArray1[i] = i;
                    numArray2[i] = i;
                }
            }
            else
            {
                for (int i = size - 1; i >= 0; i--)
                {
                    numArray1[i] = i;
                    numArray2[i] = i;
                }
            }

            List<int[]> list = new List<int[]>();

            list.Add(numArray1);
            list.Add(numArray2);

            return list;
        }

        public void SaveDataToFile(string path, string fileName)
        {
            string results = "";

            if(_lastExpResults == null)
            {
                throw new Exception("No experiment was previously executed");
            }


            for (int i = 0; i < _lastExpResults.Length; i++)
            {
                results += _lastExpResults[i] + "\n";
            }

            File.WriteAllText(path + fileName + ".csv", results);

        }
    }
}
