using System;

//bai 1
public static class UserData
{
    public static string UserName;
    public static int ID;
    public static float Health;
    public static int Points;

    static UserData()
    {
        UserName = "Hide on bush";
        ID = 2024;
        Health = 100.5f;
        Points = 100;
    }
}



public class Program
{
    static void Main(string[] args)
    {
        //bai 1
        Console.WriteLine("User Name: " + UserData.UserName);
        Console.WriteLine("ID: " + UserData.ID);
        Console.WriteLine("Gold: " + UserData.Health);
        Console.WriteLine("Points: " + UserData.Points);

        
        

    }
}
