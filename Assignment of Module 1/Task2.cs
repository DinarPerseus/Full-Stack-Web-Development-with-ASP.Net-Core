int[] storeIntegerData = new int[5];

Console.WriteLine("Please enter 5 integer values:");
for (int i = 0; i < storeIntegerData.Length; i++)
{
    storeIntegerData[i] = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Data stored successfully.");

Console.Write("Stored data: ");
for (int i = 0; i < storeIntegerData.Length; i++)
{
    Console.Write(storeIntegerData[i]+" ");
}
