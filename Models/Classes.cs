
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Goose_Panda_Love_Coffee.Models;

public class Classes
{
    public int ClassesId { get; set; }
    [Display(Name = "Class Name")]
    public string? ClassName { get; set; }

    public string? Teacher { get; set; }
    public virtual List<Student>? Enrolled {get; set;}
}