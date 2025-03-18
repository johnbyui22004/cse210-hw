class MotherTeresa : Person
{
    private string _charity;

    public MotherTeresa(string charity, string firstName, string lastName, int age)
    : base(firstName, lastName, age)
    {
        _charity = charity;
    }
    
    public string DisplayMotherTeresaInfo()
    {
        return $"Traits: {_charity}, {DisplayPersonInfo()}";
    }
}
