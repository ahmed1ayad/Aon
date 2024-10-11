using System;
using static System.Net.WebRequestMethods;
class program
{
    const string username = "ali";
    const string password = "22.2";
    static void Main()
    {

        Console.WriteLine("Welcome to the Simple Login System!");
        Console.Write("enter your username:");
        string inputusername = Console.ReadLine();
        if (inputusername is null)
        {
            Console.WriteLine("Username cannot be empty");
        }
        Console.Write("enter your password:");
        string inputpassword = Console.ReadLine();
        if (inputpassword is null)
        {
            Console.WriteLine("password cannot be empty");
        }

        if (inputusername != username || inputpassword != password)
        {
            Console.WriteLine("Invalid username or password. Access denied");
        }
        else
        {
            Random ar = new Random();
            int otp = ar.Next(100000, 999999);
            Console.WriteLine(otp);


            Console.Write("enter your otp:");
            string inputotp = Console.ReadLine();
            string inoutotp1 = otp.ToString();
            if (inputotp != inoutotp1)
            {
                Console.WriteLine("Invalid OTP. Access denied");
            }
            else
            {
                Console.WriteLine("Success! You are logged in");
            }


        }
    }
} 