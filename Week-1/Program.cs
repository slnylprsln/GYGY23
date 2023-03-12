/* Arraylerde ortalama, minimum, maksimum değerleri bulmak */

Console.WriteLine("ÖRNEK 1");

int[] array = { 30, 5, 60, 3, 7, 2, 8, 22 };
Console.WriteLine("Ortalama, minimum, maksimum bulunan array: " + string.Join(",", array));

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
Console.WriteLine();



/* İki farklı integer array'i toplamak */

Console.WriteLine("ÖRNEK 2");

int[] array1 = { 3, 7, 8, 9, 15, 2 };
int[] array2 = { 4, 9, 3, 18, 22 };

int sumArrayLength;

if (array1.Length < array2.Length)
{
    sumArrayLength = array1.Length;
}
else
{
    sumArrayLength = array2.Length;
}
int[] sumArray = new int[sumArrayLength];

for (int i = 0; i < sumArray.Length; i++)
{
    sumArray[i] = array1[i] + array2[i];
}

Console.WriteLine("Toplanan array 1: " + string.Join(",", array1));
Console.WriteLine("Toplanan array 2: " + string.Join(",", array2));
Console.WriteLine("Toplam array: " + string.Join(",", sumArray));

