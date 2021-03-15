using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HairSalon.Models
{
  public class Stylist
  {
    public Stylist()
    {
      this.Clients = new HashSet<Client>();
    }

    public int StylistId { get; set; }
    [Required]
    [Display(Name="Name")]
    public string StylistName { get; set; }
    [Required]
    [DataType(DataType.PhoneNumber)]
    [Display(Name="Phone")]
    [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
    public string StylistPhone { get; set; }
    [Required]
    [EmailAddress]
    [Display(Name="Email")]
    public string StylistEmail { get; set; }
    [Required]
    [Display(Name="Bio")]
    public string StylistBio { get; set; }
    [Required]
    public string Specialty { get; set; }
    [Display(Name="Hire Date")]
    public DateTime HireDate { get; set; }
    public virtual ICollection<Client> Clients { get; set; }
  }
}