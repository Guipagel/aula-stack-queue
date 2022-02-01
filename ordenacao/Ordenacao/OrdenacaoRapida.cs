using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula.ordenacao.Ordenacao
{
    public class OrdenacaoRapida
    {
        public static void Quicksort(int[] elementos, int left, int right)
        {
            int i = left, j = right;
            IComparable pivot = elementos[(left + right) / 2];

            while (i <= j)
            {
                while (elementos[i].CompareTo(pivot) < 0)
                {
                    i++;
                }

                while (elementos[j].CompareTo(pivot) > 0)
                {
                    j--;
                }

                if (i <= j)
                {
                    int tmp = elementos[i];
                    elementos[i] = elementos[j];
                    elementos[j] = tmp;

                    i++;
                    j--;
                }
            }

            if (left < j)
            {
                Quicksort(elementos, left, j);
            }

            if (i < right)
            {
                Quicksort(elementos, i, right);
            }
        }
    }
}
