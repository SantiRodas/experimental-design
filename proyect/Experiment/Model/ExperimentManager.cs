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

        //Comma separated values first line experiment #, second headers for each experiment then values
        private List<String> _expResults; 

        private readonly Random _ranNumGen;

        private int _experimentId;

        private Stopwatch _stopwatch;

        public List<String> ExpResults
        {
            get
            {
                return _expResults;
            }

        }
        // -----------------------------------------------------------------------------------------

        // Constructor method of the class Controller

        public ExperimentManager()
        {
            _expResults = new List<string>();
            _ranNumGen = new Random();
            _experimentId = 1;
            _stopwatch = new Stopwatch();
        }

        // -----------------------------------------------------------------------------------------

        // Principal method of the proyect Experiment
        // Modify in case a progress bar wants to be added in user interface
        public bool StartExperiment(int arraySize, int rep, Order order)
        {
            _expResults.Add("Experiment #" + _experimentId);
            _expResults.Add("Repetition,Size,Order,BubbleTime(ms),SelectionTime(ms)");
            _experimentId++;

            for (int i = 1; i <= rep; i++)
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

                _stopwatch.Start();

                SortAlgorithms.BubbleSort(numArrayBubble);

                _stopwatch.Stop();

                long bubbleTime = _stopwatch.ElapsedMilliseconds;

                _stopwatch.Reset();
                _stopwatch.Start();

                SortAlgorithms.InsertionSort(numArrayInsertion);

                _stopwatch.Stop();

                long insertionTime = _stopwatch.ElapsedMilliseconds;
                _stopwatch.Reset();

                _expResults.Add(i + "," + arraySize + "," + order + "," + bubbleTime + "," + insertionTime);

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

        public void SaveDataToFile(string completePath)
        {
            string results = "";

            if(_expResults == null)
            {
                throw new Exception("No experiment data is saved");
            }


            for (int i = 0; i < _expResults.Count; i++)
            {
                results += _expResults[i] + "\n";
            }

            File.WriteAllText(completePath, results);

        }
    }
}
