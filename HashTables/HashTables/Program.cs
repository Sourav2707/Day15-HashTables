using System.Collections;
using HashTables;

class Program
{
    MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
    public void Frequency(string str)
    {

        // Split the string by spaces
        string[] a = str.Split(' ');
        for(int j = 0; j < a.Length; j++)
        {  
            string word = a[j];
            int count = 0;
            for (int i = 0; i < a.Length; i++)
            {
                if (word.Equals(a[i]))
                    count++;
            }
            Console.WriteLine($"The frequency of {a[j]} is {count}");
            hash.Add($"{j}", word);
        }
    }
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to HashTable and Binary search Tree programs");
        string str = "To be or not to be";
        Program p = new Program(); 
        p.Frequency(str);
        int j = Convert.ToInt32(Console.ReadLine());
        string n = p.hash.Get($"{j}");
        Console.WriteLine($"{j} index value is {n}");
    }
}