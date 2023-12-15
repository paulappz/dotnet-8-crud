
using System.ComponentModel.DataAnnotations;

namespace dotNetCrud.Models;

public class Category
{
    public Int64 Id { get; set; }
    [Required]

    public string Name { get; set; }  = string.Empty;   
    
    public string Description { get; set; }  = string.Empty;
    
    }
