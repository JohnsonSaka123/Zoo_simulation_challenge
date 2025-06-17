class Animal
{
  private int age;
  private string? name;

  public virtual void MakeSound()
  {
    Console.WriteLine("Animal sound");
  }

  public int Age
  {
    get { return age; }
    set
    {
      if (value < 0)
      {
        Console.WriteLine("Age cannot be negative.");
      }
      else
      {
        age = value;
      }
    }
  }
  public string Name
  {
    get { return name ?? string.Empty; }
    set { name = value; }
  }

  public void Describe()
  {
    Console.WriteLine($"I'm a {this.GetType().Name} and I'm {Age} years old.");
  }

  static void Main(string[] args)
  {
    Lion leo = new Lion();
    leo.name = "Leo";
    Console.WriteLine(leo.name);
  }
}

class Lion : Animal
{
  public override void MakeSound()
  {
    Console.WriteLine("Roar");
  }

}
class Parrot : Animal
{
  public override void MakeSound()
  {
    Console.WriteLine("Squawk");
  }
}
class Turtle : Animal
{
  public override void MakeSound()
  {
    Console.WriteLine("Murmurs");
  }
}