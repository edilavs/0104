using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Library
    {
        Product[] products;
        public void AddProduct(Product product)
        {
            Console.WriteLine("Elave olunacaq mehsulunun adini daxil edin:");
            product.Name = Console.ReadLine();
            Console.WriteLine("Elave olunacaq mehsulunun qiymetini daxil edin:");
            product.Price = Convert.ToDouble(Console.ReadLine());

            Array.Resize(ref products, products.Length + 1);
            products[products.Length - 1] = product;
        }
        public void GetProductByPrice(double min,double max)
        {
            int count = 0;
            int j = 0;
            Product[] newArray = new Product [count];
            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].Price >= min && products[i].Price <= max)
                {
                    count++;
                    newArray[j] = products[i];
                    j++;
                }
            }
            foreach (var item in newArray)
            {
                Console.WriteLine(item);
            }
        }
        public void GetProductByName(string str)
        {
            int j = 0;
            int count = 0;
            Product[] newArray = new Product [count];

            for (int i = 0; i < products.Length; i++)
            {
                if (products[i].Name.Contains(str))
                {
                    count++;
                    newArray[j] = products[i];
                }
            }
            foreach (var item in newArray)
            {
                Console.WriteLine(item);
            }


        }
    }
}
