// See https://aka.ms/new-console-template for more information
using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;



//CategoryTest();

ProductTest();

static void ProductTest()
{ 
    ProductManager productManager = new ProductManager(new EfProductDal());

    var result = productManager.GetProductDetails();
    if (result.Success==true)
    {

        foreach (var product in result.Data)
        {
            Console.WriteLine(product.ProductName);
        }
    }
    else
    {
        Console.WriteLine(result.Message);
    }

    
}

static void CategoryTest()
{
    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());

    foreach (var category in categoryManager.GetAll())
    {
        Console.WriteLine(category.CategoryName);
    }
}