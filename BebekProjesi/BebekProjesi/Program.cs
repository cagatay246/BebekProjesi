using BebekProjesi;

class Program
{
    static void Main()
    {

        Person person1 = new Person("mehmet", "ateş ");
        Person person2 = new Person();

        Console.WriteLine("\nbebek 1 bilgileri");
        person1.BilgileriYazdir();
       
        Console.WriteLine("\nbebek 2 bilgileri");
        person2.BilgileriYazdir();





    }
}