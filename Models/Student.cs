
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Goose_Panda_Love_Coffee.Models;

public class Student
{
    public int StudentId { get; set; }
    public string? First { get; set; }
    public string? Last { get; set; }
    public string? Email { get; set; }

    public int? Credit { get; set; } = 0;

    public virtual List<Class>? Courses {get;set;}

}