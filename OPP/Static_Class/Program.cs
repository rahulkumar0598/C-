static class Product
{
    public static int ProductId;
    public static string ProductName;
    public static int ProductPrice;
    
    static Product()
    {
        ProductId= 1;
        ProductName = "Soap";
        ProductPrice= 2340;
    }
  
    public static void getProduct()
    {
        Console.WriteLine(ProductName +"   "+ProductId+"   "+ProductPrice);
    }
    public static void getDiscount()
    {
        int d_amt = ProductPrice / 10;
        Console.WriteLine(d_amt);
        Console.WriteLine(ProductPrice-d_amt);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Product.getProduct();
        Product.getDiscount();
    }
}