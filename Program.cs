
int FinalArrayLength (string[] array)
{
    int l = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            l++;
        }
    }
    return l;
}

string []ArrayOfThreeCharacters (string[]array, int lengthArray)
{
    string drawerForVariable = "";
    string[] arrayEnd = new string[lengthArray];

    int j = 0;

    for (int i = 0; i < array.Length; i++)
    {

        if (array[i].Length <= 3)
        {
            drawerForVariable = array[i];
            arrayEnd[j] = drawerForVariable;
            j++;
        }
    }
    return arrayEnd;
}

string [] FillingFirstArray (int length)
{
    string value = " ";
    string [] array = new string [length];
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write("Пожалуйста, введите текст в ячейку "+ i +" : ");
        value =  Console.ReadLine();
        array[i]  = value;

    }
    return array;
}

void PrintArray (string[] arrayFirst, string []arraySecond)
{
    Console.Write("[");
    for (int i =0; i<arrayFirst.Length; i++)
    {
        Console.Write(arrayFirst[i]);
        if (i<(arrayFirst.Length-1)) Console.Write(", ");
    }
    Console.Write("]");

    Console.Write(" -> ");
    Console.Write("[");
    for (int j =0; j<arraySecond.Length; j++)
    {
        Console.Write(arraySecond[j]);
        if (j<(arraySecond.Length-1)) Console.Write(", ");
    }
    Console.Write("]");
}

Console.Write("Введите пожалуйста размер массива: ");
int lenghtFirstArray =Convert.ToInt32( Console.ReadLine());

string[] array =FillingFirstArray(lenghtFirstArray);

int l = FinalArrayLength(array);

string [] final = ArrayOfThreeCharacters(array, l);

PrintArray(array, final);

Console.WriteLine("");