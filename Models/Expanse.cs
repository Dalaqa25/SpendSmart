using System.ComponentModel.DataAnnotations;

namespace _Net_Projetcts.Models;

public class Expanse
{
    public int Id {get; set;}
    public decimal Value {get; set;}

    [Required]
    public string? Description {get;set;}
}
