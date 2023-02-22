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

    public string addList(List<int> list)
    {
        int sum = 0;
        foreach (int i in ints)
        {
            sum += i;
        }
        return sum.ToString();
    }
    public string productList(List<int> list)
    { 
       int product = 0;

        for (int x = 0; x < ints.Count; x++)
        {
            if (x == 0)
            {
              product = ints[x];
            }

              product = product * ints[x];
        }

       return product.ToString();
    }


}