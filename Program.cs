// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


int FinalArrayLength (string[] array)
{
    int l = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 4)
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

        if (array[i].Length <= 4)
        {
            drawerForVariable = array[i];
            arrayEnd[j] = drawerForVariable;
            
            Console.WriteLine(Convert.ToString (arrayEnd[j]));

            j++;
        }
    }
    return arrayEnd;
}

string [] FirstArray (int length)
{
    string value = " ";
    string [] array = new string [length];
    for (int i = 0; i < array.Length; i++)
    {
        Console.WriteLine("Пожалуйста, введите текст в ячейку "+ i +" : ");
        value =  Console.ReadLine()+" ";
        array[i]  = value;

    }
    return array;
}

//string[] array  = {"Пекарь", "Три", "End", "Виктоия", "Самосвал", "Yo"};

Console.Write("Введите пожалуйста размер массива: ");
int lenghtFirstArray =Convert.ToInt32( Console.ReadLine());


string[] array =FirstArray(lenghtFirstArray);

int l = FinalArrayLength(array);

ArrayOfThreeCharacters(array, l);
