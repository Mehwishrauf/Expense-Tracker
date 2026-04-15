using System;
using System.IO;

public class UserManager
{
    private string currentUser;

    public string Login()
    {
        Console.Write("Enter Username: ");
        string username = Console.ReadLine();

        string userFile = $"{username}.txt";

        if (!File.Exists(userFile))
        {
            Console.WriteLine("🆕 New user created!");
            File.Create(userFile).Close();
        }

        currentUser = username;
        return userFile;
    }

    public string GetCurrentUser()
    {
        return currentUser;
    }
}