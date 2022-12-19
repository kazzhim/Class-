public class Student 
{  

    public Student(string name, string surname, string group, int point, string isGraduated)
    {
        this.Name = name;
        this.Surname = surname;
        this.Group = group;
        this.Point = point;

        if (isGraduated == "Mezun")
            this.IsGraduated = true;
        else
            this.IsGraduated = false;
    }

    public string Name;
    public string Surname;
    public string Group;
    public int Point;
    public bool IsGraduated;


    public string NameAndSurname(string name, string surname)
    {
        return $"{name} {surname}";
    }

    internal void Informations()
    {
        Console.WriteLine($"Telebenin adi: {this.Name} \n" +
                          $"Soyadi: {this.Surname} \n" +
                          $"Qrupu : {this.Group} \n" +
                          $"Qiymet : {this.Point} \n");

        


        Console.WriteLine("*********************");

        if (this.IsGraduated = true)
            Console.WriteLine("Bu telebe mezun olub.");

        else
            Console.WriteLine("Mezun olmayib");
    }

    public void IsValid()
    {
        if (this.Point >= 80)
            Console.WriteLine("Ikinci imtahana gire biler");

        else
            Console.WriteLine("Ikinci imtahana gire bilmez");

    }
}

