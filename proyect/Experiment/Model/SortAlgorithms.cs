namespace Experiment.Model
{
    public static class SortAlgorithms
    {

        // -----------------------------------------------------------------------------------------

        // Bubble sort method

        public static void BubbleSort(int[] numArray)
        {
            int aux;
            for (int i = 1; i < numArray.Length; i ++)
            {
                for (int j = numArray.Length - 1; j >= i; j--)
                {
                    if (numArray[j - 1] > numArray[j])
                    {
                        aux = numArray[j - 1];
                        numArray[j - 1] = numArray[j];
                        numArray[j] = aux;
                    }
                }
            }

           
        }

        // -----------------------------------------------------------------------------------------

        // Insertion sort method

        public static void InsertionSort(int[] numArray)
        {
            int aux;
            for (int i = 1; i < numArray.Length; i ++)
            {
                aux = numArray[i];
                for (int j = i - 1; j > 0 && numArray[j] > aux; j--)
                {
                    numArray[j + 1] = numArray[j];
                    numArray[j] = aux;
                }
            }
        }

        // -----------------------------------------------------------------------------------------

    }
}
