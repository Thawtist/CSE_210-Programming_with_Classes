class Program
{
    public static void Main(string[] args)
    {
        Person person = new Person("bob", "Ross", 55, 195);

        Console.WriteLine(person.GetPersonInformation());

        Doctor myDoctor = new Doctor("Ax", "Bob", "Budge", 75, 210);
        Console.WriteLine(myDoctor.GetDoctorInformation());
    }
}