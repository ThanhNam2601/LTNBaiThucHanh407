using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstwebMVC.Models
{
    [Table("Customer")]
    public class Customer 
    {
        [Key]
        public string CustomerID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        
        
    }
}