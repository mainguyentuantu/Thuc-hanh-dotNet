
public class Animal{
    public string Name {get; set; }
    public void Move(){
        Console.WriteLine("Dang di chuyen ...");
    }
}
public class Dog : Animal{
    public void Bark(){
        Console.WriteLine("Woof");
    }
}
