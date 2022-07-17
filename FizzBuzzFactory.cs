using Kolaczyn;

class FizzBuzzFactory
{
  public IFizzBuzzer GetFizzBuzz()
  {
    return new FizzBuzz();
  }
}