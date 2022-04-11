
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Goose_Panda_Love_Coffee.Models;

public class Classes
{
    public int ClassesId { get; set; }
    public string? ClassName { get; set; }

    public string? Teacher { get; set; }
}