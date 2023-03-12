/* ARRAYS */

int[] array = { 30, 5, 60, 3, 7, 2, 8, 22 };

// Integer array'inin ortalamasını bulma
int summation = 0;
for (int i = 0; i < array.Length; i++)
{
    summation += array[i];
}
int mean = summation / array.Length;
Console.WriteLine("Verilen array'in ortalaması: {0}", mean);

// Integer array'inin minimum değerini bulma
int min = array[0];
for (int i = 0; i<array.Length; i++)
{
    if (array[i] < min)
    {
        min = array[i];
    }
}
Console.WriteLine("Verilen array'in minimum değeri: {0}", min);

// Integer array'inin maksimum değerini bulma
int max = array[0];
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
}
Console.WriteLine("Verilen array'in maksimum değeri: {0}", max);