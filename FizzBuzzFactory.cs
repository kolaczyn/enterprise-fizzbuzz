using Kolaczyn;

class FizzBuzzFactory
{
  public static IFizzBuzzer GetFizzBuzz()
  {
    var fizzBuzzFormatter = new FizzBuzzFormatter();
    return new FizzBuzz(fizzBuzzFormatter);
  }
}