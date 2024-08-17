class SuperParent
{

}
sealed class Parent:SuperParent
{
	public Parent()
	{

	}
	public void show()
	{
		Console.WriteLine("Parent");
	}
}
class Child:Parent
{

}
class Program
{
	static void Main(string[] args)
	{

	}
}