using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

//SOLİD
//Open Closed Program

class Program
{
    public static void Main(string[] args)
    {
        ProductManager productManager = new ProductManager(new EfProductDal());

        foreach (var product in productManager.GetByUnitPrice(50,60))
        {
            Console.WriteLine(product.ProductName);
        }
    }
}