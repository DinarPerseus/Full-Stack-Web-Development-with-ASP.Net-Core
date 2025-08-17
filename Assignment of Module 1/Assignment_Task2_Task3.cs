//Task2
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
    Console.Write(storeIntegerData[i] + " ");
}
Console.WriteLine("\n");
//Task2 - End






//task3
int[] inputs = new int[3];

Console.WriteLine("Please enter 3 integer values:");
for (int i = 0; i < inputs.Length; i++)
{
    inputs[i] = Convert.ToInt32(Console.ReadLine());
}


int maxIndex,minIndex;

if (inputs[0] > inputs[1] && inputs[0] > inputs[2])
{
    maxIndex = 0;
}
else if (inputs[1] > inputs[2])
{
    maxIndex = 1;
}
else
{
    maxIndex = 2;
}


Console.WriteLine($"The largest number is: {inputs[maxIndex]}");

//swap the largest number with the third element
(inputs[2], inputs[maxIndex]) = (inputs[maxIndex], inputs[2]);



switch (inputs[0] < inputs[1])
{
    case true:
        minIndex = 0;
        break;
    default:
        minIndex = 1;
        break;
}


Console.WriteLine($"The smallest number is: {inputs[minIndex]}");
//task3 - End