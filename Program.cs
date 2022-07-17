for (int i = 0; i < 100; i++)
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
