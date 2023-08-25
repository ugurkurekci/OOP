namespace Encapsulation;

public class Student
{

    private string name;
    private int age;

    public string GetName()
    {
        return name;
    }

    public void SetName(string newName)
    {
        if (!string.IsNullOrEmpty(newName))
        {
            name = newName;
        }
    }

    public int GetAge()
    {
        return age;
    }

    public void SetAge(int newAge)
    {
        if (newAge >= 0)
        {
            age = newAge;
        }
    }
}
