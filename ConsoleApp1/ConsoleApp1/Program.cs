using System.Text;

string inputString = "Hello World!";
byte[] bytesToEncode = Encoding.UTF8.GetBytes(inputString);
string encodedString = Convert.ToBase64String(bytesToEncode);
Console.WriteLine(encodedString);