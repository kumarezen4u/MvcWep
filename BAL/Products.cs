using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebMvc.BAL
{
    [Table("Products")]
    public class Products
    {
        [Key]
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int SupplierID { get; set; }
        public int CategoryID { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }       
        public System.Int16 UnitsInStock { get; set; }
        public System.Int16 UnitsOnOrder { get; set; }       
        public System.Int16 ReorderLevel { get; set; }
        public bool Discontinued { get; set; }
    }


    public class ProductModel
    {
        ///<summary>
        /// Gets or sets Customers.
        ///</summary>
        public List<Products> Products { get; set; } 

        ///<summary>
        /// Gets or sets CurrentPageIndex.
        ///</summary>
        public int CurrentPageIndex { get; set; }

        ///<summary>
        /// Gets or sets PageCount.
        ///</summary>
        public int PageCount { get; set; }

        public int TotalRecords { get; set; }
    }
}