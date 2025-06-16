class Animal
{
  public int age;
  public string name;

  public virtual void MakeSound()
  {
    Console.WriteLine("Animal sound");
  }

  private int AnimalAge
  {
    get { return age; }
    set
    {
      if (age < 0)
      {
        Console.WriteLine("Age cannot be negative.");
      }
      else
      {
        age = value;
      }
    }
  }
  private string AnimalName
  {
    get { return name; }
    set { name = value; }
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