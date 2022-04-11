
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Goose_Panda_Love_Coffee.Models;

public class StudentClasses
{
    public int StudentClassesId { get; set; }
    public virtual Student? Student {get;set;}

    public virtual Classes? Classes {get;set;}
   
    public int? Credit { get; set; } = 0;

}