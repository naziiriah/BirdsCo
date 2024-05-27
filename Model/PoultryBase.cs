using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace BirdsCo.Model;

public class MainFarmBase
{

    [ValidateNever]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    [Key]
    public Guid Guid { get; set; } = Guid.NewGuid();
}
