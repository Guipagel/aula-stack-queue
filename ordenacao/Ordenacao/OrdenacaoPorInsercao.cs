namespace aula.ordenacao.Ordenacao
{
    public class OrdenacaoPorInsercao
    {
        public static void insertionSort(int[] elementos)
        {
            int temp, j;
            for (int i = 1; i < elementos.Length; i++)
            {
                temp = elementos[i];
                j = i - 1;

                while (j >= 0 && elementos[j] > temp)
                {
                    elementos[j + 1] = elementos[j];
                    j--;
                }

                elementos[j + 1] = temp;
            }
        }
    }
}
