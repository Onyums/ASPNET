﻿using ASPNET.Models;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNET
{
    public class ProductRepo : IProductRepo
    {
        private readonly IDbConnection _conn;
        public IEnumerable<Product> GetAllProdcuts()
        {
            return _conn.Query<Product>("SELECT * FROM PRODUCTS;");
        }

        public Product GetProduct(int id)
        {
            return (Product)_conn.QuerySingle<Product>("SELECT * FROM PRODUCTS WHERE PRODUCTID = @id",
                new { id = id });
        }

        public void UpdateProduct(Product product)
        {
            _conn.Execute("UPDATE products SET Name = @name, Price = @price WHERE ProductID = @id",
               new { name = product.name, price = product.price, id = product.productID });

        }

        public ProductRepo(IDbConnection conn)
        {
            _conn = conn;
        }
    }
}
