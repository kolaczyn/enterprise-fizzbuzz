namespace Kolaczyn;

class FizzBuzz : IFizzBuzzer
{
  void IFizzBuzzer.Buzz(int num)
  {
    for (int i = 0; i < num; i++)
    {
      var str = "";
      if (i % 3 == 0) { str += "Fizz"; }
      if (i % 5 == 0) { str += "Buzz"; }
      if (str == "")
      {
        str = i.ToString();
      }
      Console.WriteLine(str);
    }
  }
}