using System.Text;

string inputString = "esb:app";
byte[] bytesToEncode = Encoding.UTF8.GetBytes(inputString);
string a=Convert.ToBase64String(bytesToEncode);
Console.WriteLine(a);

foreach (byte b in bytesToEncode)
{
    Console.WriteLine(b);
}
