// See https://aka.ms/new-console-template for more information

using static System.Console;

int[] arr = {-1,-34,0,5,96,0,47,-13,0,-24,24,27,-8,8,-13,0,36,47 };
foreach (int i in arr) { Write($"{i} "); }
WriteLine();
//1.Сжать массив, удалив из него все 0 и, заполнить ос-
//вободившиеся справа элементы значениями –1

int a = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] == 0)
    {
        a++;
        int z = -1;
        for (int k = i + 1, l = i; k < arr.Length; k++, l++)
        {
            arr[l] = arr[k];
        }
        arr[arr.Length - a] = z;
    }
}
WriteLine($"Колличество нулей = {a}");
foreach (int i in arr) { Write($"{i} "); }
WriteLine();

////////////////////////////////////////////////////////////////////
//2.	Преобразовать массив так, чтобы сначала шли все
//отрицательные элементы, а потом положительные
//(0 считать положительным)


for (int i = 0; i < arr.Length; i++)
{
    for (int l = i + 1; l < arr.Length; l++)
    {
        if (arr.Length - 1 != i)
        {
            if (arr[i] > arr[l]) { int tmp = arr[i]; arr[i] = arr[l]; arr[l] = tmp; }
        }
    }
}
foreach (int i in arr) { Write($"{i} "); }
WriteLine();

//for (int i = 0; i < arr.Length; i++)
//{
//    if (arr.Length - 1 == i) { WriteLine($"{arr[i]}"); }
//    else { Write($"{arr[i]},"); }
//}

////////////////////////////////////////////////////////////////////
//3.Написать программу, которая предлагает пользова-
//телю ввести число и считает, сколько раз это число
//встречается в массиве.

WriteLine("введите число : "); int read = Convert.ToInt32(ReadLine());
int count = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (read == arr[i]) count++;
}
WriteLine($"Число {read} встречается в массиве {count} раз");

////////////////////////////////////////////////////////////////////
//4.	В двумерном массиве порядка M на N поменяйте
//местами заданные столбцы
const int M = 2;
const int N = 4;
int[,] matrix_2d =new int[M,N] { {2,5,8,13 }, {-21,34,-55,89} };
///foreach (int i in matrix_2d) { Write($"{i} "); }
for (int i = 0; i < M; i++){
    for (int j = 0; j < N; j++){
        Write($" {matrix_2d[i, j]} ");
    }
    WriteLine();
}

WriteLine();
WriteLine("Ведите номера первого столбца :");int left = Convert.ToInt32(Console.ReadLine())-1;
WriteLine("Ведите номера второго столбца :");int right = Convert.ToInt32(Console.ReadLine())-1;
if ((left > N)||(right > N))  { WriteLine("Ошибка ввода!!!!!!!"); }
    
        else {
            if (left > right) { int tmp = left; left = right; right = tmp; }

            for (int i = 0; i < M; i++) {
                for (int j = 0; j < N; j++) {
                    if (j == left) { 
                        int tmp = matrix_2d[i, j]; 
                        matrix_2d[i, j] = matrix_2d[i, right];
                        matrix_2d[i, right] = tmp;
                     }
                    //Write($"{matrix_2d[i, j]} ");
                }
                WriteLine();
            }
        }

for (int i = 0; i < M; i++)
{
    for (int j = 0; j < N; j++)
    {
        Write($" {matrix_2d[i, j]} ");
    }
    WriteLine();
}

