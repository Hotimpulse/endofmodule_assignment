string[] originalArray = {"hello", "2", "world", ":-)"};

Console.WriteLine("Example array is: [" + string.Join(", ", originalArray) + "]");

Console.Write("Array of strings that are < 4 symbols in length: ");

int count = 0;
for (int i = 0; i < originalArray.Length; i++)
{
    if (originalArray[i].Length < 4) {
        count++;
    }
}

string[] sortedArray = new string[count];
int result = 0;

for (int i = 0; i < 4; i++)
{
    if (originalArray[i].Length < 4) {
        sortedArray[result++] = originalArray[i];
    }
}

Console.Write($"[{String.Join(", ", sortedArray)}]");