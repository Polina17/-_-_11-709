using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmoothSort
{
    public class SmoothSort
    {
        // принцип формирования чисел Леонардо L(N) = L(N-1) + L(N-2) + 1

        private readonly int[] _leoNum =
        {
            1, 1, 3, 5, 9, 15, 25, 41, 67, 109, 177, 287, 465, 753, 1219, 1973, 3193, 5167, 8361, 13529, 21891, 35421,
            57313, 92735, 150049, 242785, 392835, 635621, 1028457, 1664079, 2692537, 4356617, 7049155, 11405773,
            18454929, 29860703, 48315633, 78176337, 126491971, 204668309, 331160281, 535828591, 866988873, 1402817465
        }; // числа леонардо

        private int _curState;

        // Переменная CurState – это текущее состояние последовательности куч, двоичное представление которой задает размерности этих куч.

        // Двоичное представление числа CurState является описанием

        // текущего состояния массива куч.

        // Двоичное представление:  10110

        // Числа Леонардо           95311

        // Т.е. первые 9 элементов - это первая куча, вторые 3 - вторая куча,

        // и последний - это третья куча

        // После выполнение функции число CurState будет описывать массив куч после добавления

        // одного элемента в конец. Его двоичное представление будет 11000 = 24.

        // Результат: Номер бита, соответствующий вершине последней кучи, если та состоит более,

        // чем из одного элемента

        private int NextState(ref int curState) // Функция NextState, делает обратную операцию, но при этом она еще возвращает номер бита, соответствующий вершине последней кучи, если та состоит более чем из одного элемента. В противном случае функция возвращает –1.
        {
            int posNewTop = -1; // позиция вершины объединенных куч.
            // исключение
            if ((curState & 7) == 5)
            {
                // CurState = 0101
                curState += 3; // CurState = 1000
                posNewTop = 3;
            }
            else // пытаемся найти два подряд единичных бита
            {
                int next = curState;
                int pos = 0;
                while (next != 0 && (next & 3) != 3)
                {
                    next >>= 1;
                    pos++;
                }

                if ((next & 3) == 3) // CurState = 01100
                {
                    curState += 1 << pos; // CurState = 10000
                    posNewTop = pos + 2;
                }
                else if ((curState & 1) != 0) // CurState = x001
                    curState |= 2; // CurState = x011
                else // CurState = xx00
                    curState |= 1; // CurState = xx01
            }
            return posNewTop;
        }

        private void PrevState(ref int curState) //Функция PrevState изменяет текущее состояние с учетом того, что вершина последней кучи исключена из рассмотрения.
        {
            if ((curState & 15) == 8)
            {
                // CurState = 1000
                curState -= 3; // CurState = 0101
            }
            else if ((curState & 1) != 0)
            {
                if ((curState & 3) == 3) // CurState = x011
                    curState ^= 2; // CurState = x001
                else // CurState = xx01
                    curState ^= 1; // CurState = xx00
            }
            else // ищим первый единичный бит
            {
                int prev = curState;
                int pos = 0;
                while (prev != 0 && !(Convert.ToBoolean(prev & 1)))
                {
                    prev >>= 1;
                    pos++;
                }
                if (prev != 0) // CurState = xx10000
                {
                    curState ^= 1 << pos;
                    curState |= 1 << (pos - 1);
                    curState |= 1 << (pos - 2); // CurState = xx01100

                }
                else
                    curState = 0;
            }
        }

        private void ShiftDown(int[] mas, int posHeapItemsAmount,
                int indexLastTop) // Реализация функции просейки вниз, в ней задается также mas[]
        {
            int posCurNode = indexLastTop; //indexLastTop - индекс крайней вершины
            while (posHeapItemsAmount > 1
            ) //nextPosHeapItemsAmount - количество элементво в кучи, вершина которой оказалось максимальной из всех вершин куч
            {
                // позиция правого сына
                int posR = posCurNode - 1;
                // позиция левого сына
                int posL = posR - _leoNum[posHeapItemsAmount - 2]; // число элементов в текущей кучи
                int posMaxChild = posL;
                int posNextTop = posHeapItemsAmount - 1;
                if (mas[posR] > mas[posL]) // если позиция правого сына больше левого
                {
                    posMaxChild = posR; // то "старший сын" правый
                    posNextTop = posHeapItemsAmount - 2;
                }
                if (mas[posCurNode] < mas[posMaxChild])
                {
                    Swap(ref mas[posCurNode], ref mas[posMaxChild]);
                    posHeapItemsAmount = posNextTop;
                    posCurNode = posMaxChild;
                }
                else
                    break;
            }
        }

        private void MakeHeapPool(int[] mas) // Функция создания последовательности куч из произвольного массива.
        {
            for (int i = 0; i < mas.Length; i++)
            {
                int posHeapItemsAmount = NextState(ref _curState);
                if (posHeapItemsAmount != -1)
                    ShiftDown(mas, posHeapItemsAmount, i);
            }
        }
        // Среди вершин куч находим максимальный элемент

        // mas - массив

        // CurState - число, двоичное представление которого описывает текущий массив куч

        // indexLastTop - индекс крайней вершины

        // nextPosHeapItemsAmount - количество элементво в кучи, вершина которой оказалось максимальной из всех вершин куч

        // Возврат: индекс элемента(одной из вершин кучи), который больше чем остальные вершины куч

        private int FindPosMaxElem(int[] mas, int curState, int indexLastTop, ref int nextPosHeapItemsAmount) // Функция поиска максимального элемента среди вершин куч
        {
            int pos = 0;
            // ищим позицию первого единичного бита
            while (!Convert.ToBoolean(curState & 1))
            {
                curState >>= 1;
                pos++;
            }
            int posMaxTopElem = indexLastTop;
            nextPosHeapItemsAmount = pos;
            int curTopElem = indexLastTop - _leoNum[pos];
            curState >>= 1;
            pos++;
            while (curState != 0)
            {
                if ((curState & 1) != 0)
                {
                    if (mas[curTopElem] > mas[posMaxTopElem])
                    {
                        posMaxTopElem = curTopElem;
                        nextPosHeapItemsAmount = pos;
                    }
                    curTopElem -= _leoNum[pos];
                }
                curState >>= 1;
                pos++;
            }
            return posMaxTopElem;
        }

        public void Sort(int[] mas) // функция плавная сортировки
        {
            MakeHeapPool(mas); // вызов функции, создающей последовательность куч из произвольного массива

            for (int i = mas.Length - 1; i >= 0; i--)
            {
                int nextPosHeapItemsAmount = 0;

                int posMaxTopElem =
                    FindPosMaxElem(mas, _curState, i,
                        ref nextPosHeapItemsAmount); // максимальный верхний элемент кучи получает значение в виде результата функции FindPosMaxElem

                if (posMaxTopElem != i)
                {
                    Swap(ref mas[i],
                        ref mas[posMaxTopElem]); // вызываем функцию Swap и передаем в нее значения mas[i] и mas[posMaxTopElem]
                    ShiftDown(mas, nextPosHeapItemsAmount, posMaxTopElem); // вызываем функцию ShiftDown
                }
                PrevState(ref _curState); // вызываем функцию PreveState и передаем значения, ссылаясь(ref) на значение переменной CurState
            }
        }

        private void Swap(ref int a, ref int b) // функция перестановки
        {
            int temp = b;
            b = a;
            a = temp;
        }
    }
}
