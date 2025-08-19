using System;
using System.Collections.Generic;


public class Product
{
    public string Name { get; set; }
    public double Price { get; set; }

    public Product(string name, double price)
    {
        Name = name;
        Price = price;
    }
}


public class Order
{
    public List<Product> Products { get; set; }

    public Order()
    {
        Products = new List<Product>();
    }

  
    public double GetTotalPrice()
    {
        double total = 0;
        foreach (var product in Products)
        {
            total += product.Price;
        }
        return total;
    }
}

public class Program
{
    public static void Main()
    {
       
        Product p1 = new Product("Laptop", 800);
        Product p2 = new Product("Mouse", 20);
        Product p3 = new Product("Keyboard", 50);

       
        Order order = new Order();
        order.Products.Add(p1);
        order.Products.Add(p2);
        order.Products.Add(p3);

       
        Console.WriteLine("Total Price of Order: $" + order.GetTotalPrice());
    }
}

