class Doctor : Person
{
    private string _tools;

    public Doctor(string tools, string firstName, string lastName, int age) 
    : base(firstName, lastName, age)
    {
        _tools = tools;
    }

    public string GetPoliceInfo()
    {
        return $"tools: {_tools}, {GetPersonInfo()}";
    }

    public override string GetName()
    {
        return $"Dr. {base.GetName()}";
    }

    public override string GetHobbies()
    {
        return $"As Doctor I enjoy digging big holes";
    }

}