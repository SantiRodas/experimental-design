namespace Experiment.model
{
    class Methods
    {

        // -----------------------------------------------------------------------------------------

        // Bubble method

        public void bubble(int[] numbers)
        {
            int aux;
            for (int i = 1; i < numbers.Length; i ++)
            {
                for (int j = numbers.Length - 1; j >= i; j--)
                {
                    if (numbers[j - 1] > numbers[j])
                    {
                        aux = numbers[j - 1];
                        numbers[j - 1] = numbers[j];
                        numbers[j] = aux;
                    }
                }
            }
        }

        // -----------------------------------------------------------------------------------------

        // Insertion method

        public void insertion(int[] numbers)
        {
            int aux;
            for (int i = 1; i < numbers.Length; i ++)
            {
                aux = numbers[i];
                for (int j = i - 1; j > 0 && numbers[j] > aux; j--)
                {
                    numbers[j + 1] = numbers[j];
                    numbers[j] = aux;
                }
            }
        }

        // -----------------------------------------------------------------------------------------

    }
}
