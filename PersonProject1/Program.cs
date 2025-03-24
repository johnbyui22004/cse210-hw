// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        PoliceMan myPoliceMan = new PoliceMan("Gun", "John", "Earl", 19);
        Console.WriteLine($"{myPoliceMan.GetPoliceInfo()}");

        myPoliceMan.SetHight(6);
        Console.WriteLine($"hight {myPoliceMan.GetHight()}");

        MotherTeresa myMotherTeresa = new MotherTeresa("Charity", "Mother" , "Teresa", 77);
        Console.WriteLine($"{myMotherTeresa.GetMotherTeresaInfo()}");
        Console.WriteLine($"{myMotherTeresa.GetHobbies()}");

        Console.WriteLine($"Police man hight: {myPoliceMan.GetHight()}");
        Console.WriteLine($"{myPoliceMan.GetName()}");
        Console.WriteLine($"{myPoliceMan.GetHobbies()}");

        Doctor myDoctor = new Doctor("Scalpel", "Micah", "Earl", 20);
        Console.WriteLine($"{myDoctor.GetName()}");

        Console.WriteLine($"{myDoctor.GetHobbies()}");
        
        

    }
    

}


