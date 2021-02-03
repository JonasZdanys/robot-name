using System;
using System.Collections.Generic;

public class Robot
{
    private static Random _rand = new Random();
    public static HashSet<string> NameList = new HashSet<string>();
    string name;
    static string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    public Robot()
    {
        name = NewName();
    }
    public string Name
    {
        get
        {
            return name;
        }
    }
    public void Reset()
    {
        name = NewName();
    }
    public static string NewName()
    {
        string TheName = $"{letters[_rand.Next(0, 25)].ToString()}" + $"{letters[_rand.Next(0, 25)].ToString()}" + $"{_rand.Next(9)}"+ $"{_rand.Next(9)}"+ $"{_rand.Next(9)}";
        if (NameList.Contains(TheName))
        {
            TheName = NewName();
        }
        else
        {
            NameList.Add(TheName);
        }
        return TheName;
    } 
}