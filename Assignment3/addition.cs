﻿// See https://aka.ms/new-console-template for more information

public class sumOfList
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


}