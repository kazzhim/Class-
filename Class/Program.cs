Console.Write("Telebenin adini yazin: ");
string name = Console.ReadLine();

Console.Write("Telebenin soyadini yazin: ");
string surname = Console.ReadLine();

Console.Write("Telebenin qrup nomresini yazin: ");
string group = Console.ReadLine();

Console.Write("Telebenin qiymetini yazin: ");
int point = int.Parse(Console.ReadLine());

Console.Write("Telebe veziyyeti");
string isGraduated = Console.ReadLine();


Student student = new Student(name, surname, group, point, isGraduated);


student.Informations();
Console.WriteLine("*********************");
student.IsValid();











