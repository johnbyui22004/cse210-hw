class PoliceMan : Person
{
    private string _weapons;

    public PoliceMan(string weapons, string firstName, string lastName, int age) 
    : base(firstName, lastName, age)
    {
        _weapons = weapons;
    }

    public string GetPoliceInfo()
    {
        return $"Weapons: {_weapons}, {GetPersonInfo()}";
    }

    public override string GetName()
    {
        return $"sargeant {base.GetName()}";
    }

        public override string GetHobbies()
    {
        return $" my hobbies are Shooting bad guys";
    }

}