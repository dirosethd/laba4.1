double[] array1 = { 1.0, 2.0, 3.0, 4.0, 5.0, 6.0, 7.0, 8.0, 9.0, 10.0, 11.0, 12.0 };
double[] array2 = { 3.0, 5.0, 7.0, 0.0, 10.0, 15.0, 20.0, 25.0, 30.0, 35.0, 40.0, 45.0 };
for (int i = 0; i < array1.Length; i++)
{
    for (int j = 0; j < array2.Length; j++)

    {
        if (array1[i] == array2[j])
        {
            array1[i] = 0.0;
            break;
        }
    }
}
Console.WriteLine("Измененный масив: ");
foreach (var item in array1)
{ Console.WriteLine(item); }