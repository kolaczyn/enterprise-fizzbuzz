namespace Kolaczyn;

class FizzBuzzFormatter : IFizzBuzzFormatter
{
  public string Format(int num)
  {
    var str = "";
    if (num % 3 == 0) { str += "Fizz"; }
    if (num % 5 == 0) { str += "Buzz"; }
    if (str == "")
    {
      str = num.ToString();
    }
    return str;
  }
}