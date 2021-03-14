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
    public string StylistName { get; set; }
    [Required]
    [DataType(DataType.PhoneNumber)]
    [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
    public string StylistPhone { get; set; }
    [Required]
    [EmailAddress]
    public string StylistEmail { get; set; }
    [Required]
    public string StylistBio { get; set; }
    [Required]
    public string Specialty { get; set; }
    public DateTime HireDate { get; set; }
    public virtual ICollection<Client> Clients { get; set; }
  }
}