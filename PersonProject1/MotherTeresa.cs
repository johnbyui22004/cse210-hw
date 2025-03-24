class MotherTeresa : Person
{
    private string _charity;

    public MotherTeresa(string charity, string firstName, string lastName, int age)
    : base(firstName, lastName, age)
    {
        _charity = charity;
    }
    
    public string GetMotherTeresaInfo()
    {
        return $"Traits: {_charity}, {GetPersonInfo()}";
    }

        public override string GetHobbies()
    {
        return $"I love being charitable";
    }
}
