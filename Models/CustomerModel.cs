using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebMvc.BAL;

namespace WebMvc.Models
{
    public class CustomerModel
    {
        public List<Customers> customerList { get; set; }
        public int CurrentPageIndex { get; set; }
        public int PageCount { get; set; } 
        public int TotalRecords { get; set; } 
    }
}