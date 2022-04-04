
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DotNet_Lab3_Shanshan.Models;

public class Product
{
    public int ProductId { get; set; }
    public string? Name { get; set; }
    [Range(0, 20000)]
    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(7,2)")]
    public decimal Price { get; set; } = 5.00M;
    public uint Stock { get; set; } = 0;

    //public virtual Product? Product { get; set; }

}
