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

