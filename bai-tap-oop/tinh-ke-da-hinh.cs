public class Animal{
    public virtual void MakeSound{
        Console.WriteLine("Dang tao am thanh ...");
    }
}
public class Dog : Animal{
    public override void MakeSound(){
        Console.WriteLine("Woof");
    }
}
public class Cat : Animal{
    public override void MakeSound(){
        Console.WriteLine("Meow");
    }
}