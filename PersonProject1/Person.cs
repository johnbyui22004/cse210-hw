using System.ComponentModel.DataAnnotations;

class Person
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

    public string DisplayPersonInfo()
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


}