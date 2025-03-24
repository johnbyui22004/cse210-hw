using System.ComponentModel.DataAnnotations;

abstract class Person
{
    private string _firstName;
    private string _lastName;
    private int _age;
    private int _hight;
    

    public Person(string firstName, string lastName, int age)
    {
        _firstName = firstName;
        _lastName = lastName;
        _age = age;
    }

    public string GetPersonInfo()
    {
        return $"Name:  {_firstName} {_lastName} Age: {_age}";
    }
    public int GetHight()
    {
        return _hight;
    }

    public void SetHight(int hight)
    {
        _hight = hight;
    }
    public virtual string GetName()
    {
        return $"{_firstName} {_lastName}";
    }

    public abstract string GetHobbies();


}