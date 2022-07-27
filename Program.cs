String[] massive = { "123", "4567", "GB", "HelloWorld", "IT" };

int count = 0;

for (int i = 0; i < massive.Length; i++)
{
    char[] chars = massive[i].ToCharArray();

    if (chars.Length <= 3)
    {
        count++;
    }
}

String[] newMassive = new String[count];
count = 0;

for (int i = 0; i < massive.Length; i++)
{
    char[] chars = massive[i].ToCharArray();

    if (chars.Length <= 3)
    {
        newMassive[count] = massive[i];
        count++;
    }
}

void Print(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}
Print(newMassive);
