for (int i = 0; i < 3; i++)
{
    Console.WriteLine("Enter your age;");
    string ageS = Console.ReadLine();
    int ageI = Convert.ToInt32(ageS);

    Console.WriteLine("Enter your hair color;");
    string hairColorS = Console.ReadLine();
    hairColorS = hairColorS.ToLower();

    Console.WriteLine("Enter your height;");
    string heightS = Console.ReadLine();
    int heightI = Convert.ToInt32(heightS);

    Console.WriteLine("Enter your profassion;");
    string profassionS = Console.ReadLine();
    profassionS = profassionS.ToLower();

    if (ageI > 24 && ageI < 51)
        {
        if(hairColorS == "brown" || hairColorS == "black")
            if (heightI > 169 && heightI < 186)
            {
                if (profassionS == "doctor" || profassionS == "hospital manager")
                {
                    Console.WriteLine("Suspicious!!");
                }
            }
    }
    else
    {
        Console.WriteLine("No suspicion");
    }
}