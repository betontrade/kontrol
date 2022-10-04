// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


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
            
            Console.WriteLine(Convert.ToString (arrayEnd[j]));

            j++;
        }
    }
    return arrayEnd;
}


string[] array  = {"Пекарь", "Три", "End", "Виктоия", "Самосвал", "Yo"};


int l = FinalArrayLength(array);

ArrayOfThreeCharacters(array, l);
