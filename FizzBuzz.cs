namespace Kolaczyn;

class FizzBuzz : IFizzBuzzer
{
  private IFizzBuzzFormatter fizzBuzzFormatter;

  public FizzBuzz(IFizzBuzzFormatter fizzBuzzFormatter)
  {
    this.fizzBuzzFormatter = fizzBuzzFormatter;
  }

  void IFizzBuzzer.Buzz(int num)
  {
    for (int i = 0; i < num; i++)
    {
      Console.WriteLine(this.fizzBuzzFormatter.Format(i));
    }
  }
}