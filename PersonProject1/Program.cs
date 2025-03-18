// See https://aka.ms/new-console-template for more information

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        Person myPerson = new Person("John", "Earl", 19);

        Console.WriteLine($"{myPerson.DisplayPersonInfo()}");

        PoliceMan myPoliceMan = new PoliceMan("Gun", "John", "Earl", 19);
        Console.WriteLine($"{myPoliceMan.DisplayPoliceInfo()}");

        myPoliceMan.SetHight(6);
        Console.WriteLine($"hight {myPoliceMan.GetHight()}");

        MotherTeresa myMotherTeresa = new MotherTeresa("Charity", "Mother" , "Teresa", 77);
        Console.WriteLine($"{myMotherTeresa.DisplayMotherTeresaInfo()}");

    }
    

}


