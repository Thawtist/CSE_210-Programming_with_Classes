
class Police : Person
{
    private string _weapon;

    public Police(string weapon, string firstName, string lastName, int age, int weight)
    : base(firstName, lastName, age, weight)
    {
        _weapon = weapon;
    }

    public string GetPoliceInformation()
    {
        return $"Weapon: {_weapon}, {GetPersonInformation()}";
    }
}