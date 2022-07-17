using Kolaczyn;

class FizzBuzzFactory
{
  public static IFizzBuzzer GetFizzBuzz()
  {
    return new FizzBuzz();
  }
}