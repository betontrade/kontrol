// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");




string []ArrayOfThreeCharacters (string[]array)
{
    int l = 0;
    string drawerForVariable = "";

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            l++;
        }
    }


    string[] arrayEnd = new string[l];

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

ArrayOfThreeCharacters(array);