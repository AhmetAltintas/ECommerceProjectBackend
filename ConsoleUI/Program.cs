using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

//SOLİD
//Open Closed Program

class Program
{
    public static void Main(string[] args)
    {
        // DTO = Data Transformation Object
        ProductTest();
        //CategoryTest();

        
    }

    
    
    
    
    
    
    
    
    
    
    
    
    
    
    private static void CategoryTest()
    {
        CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        foreach (var category in categoryManager.GetAll())
        {
            Console.WriteLine(category.CategoryName);
        }
    }

    private static void ProductTest()
    {
        ProductManager productManager = new ProductManager(new EfProductDal());

        var result = productManager.GetProductDetails();

        if (result.Success)
        {
            foreach (var product in productManager.GetProductDetails().Data)
            {
                Console.WriteLine(product.ProductName + " / " + product.CategoryName);
            }
        }
        else
        {
            Console.WriteLine(result.Message);
        }
        
        
    }
}