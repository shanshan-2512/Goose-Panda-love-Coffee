using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Goose_Panda_Love_Coffee.Models;

public class Class{
    public int classId {get;set;}
    [Display(Name = "Class Name")]
    public string? className {get;set;}

    public virtual List<Student>? Enrolled {get; set;}

}