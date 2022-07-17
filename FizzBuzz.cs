namespace Kolaczyn;

class FizzBuzz : IFizzBuzzer
{
  void IFizzBuzzer.Buzz(int num)
  {
    var fbf = new FizzBuzzFormatter();
    for (int i = 0; i < num; i++)
    {
      Console.WriteLine(fbf.Format(i));
    }
  }
}