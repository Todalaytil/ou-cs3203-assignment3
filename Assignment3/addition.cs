// See https://aka.ms/new-console-template for more information

public class integerList
{
    List<int> ints;

    public void list()
    {
        ints = new List<int>();
    }

    public void list(List<int> list)
    {
        ints = list;
    }

    public string addList()
    {
        int sum = 0;
        foreach (int i in ints) 
        {
            sum += i;
        }
        return sum.ToString();
    }
    public string productList()
    { 
       int product = 0;

        for (int x = 0; x < ints.Count; x++)
        {
            if (x == 0)
            {
              product = ints[x];
                continue;
            }

              product = product * ints[x];
        }

       return product.ToString();
    }

    public void addNumber(int num)
    {
        ints.Add(num);
    }

    public List<int> reversalList()
    {
        List<int> reversed = new List<int>;
        for(int x = ints.Count - 1; x >= 0; x--)
        {
            reversed.Add(ints[x]);
        }
        return reversed;
    }

    public static void Main()
    {

        Console.WriteLine("Would you like to add a number to the list?");
        string input = Console.ReadLine();
        input = input.ToLower();
        var list = new integerList();
        list.list();
        while (input == "yes")
        {
            Console.WriteLine("Please tell the system what number you would like to add to the list?");
            string number = Console.ReadLine();
            int num = Convert.ToInt32(number);
            list.addNumber(num);
            Console.WriteLine("Would you like to add another number to the list?");
            input = Console.ReadLine();
            input = input.ToLower();
            if(input != "yes")
            {
                continue;
            }
        }
        

        string additionOutput = list.addList();
        string productOutput = list.productList();

        Console.WriteLine($"The sum of the list is {additionOutput} and the product of the list is {productOutput}");
        Console.WriteLine("Enter another key to exit application");
        input = Console.ReadLine();
    }
}