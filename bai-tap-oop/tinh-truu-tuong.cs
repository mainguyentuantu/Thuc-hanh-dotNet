public interface IAnimal{
    void MakeSound();
}

public class Dog : IAnimal{
    public void MakeSound(){
        Console.WriteLine("Woof");
    }
}

public class Cat : IAnimal{
    public void MakeSound(){
        Console.WriteLine("Meoww");
    }
}
