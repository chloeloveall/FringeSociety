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
    public string StylistName { get; set; }
    public string StylistPhone { get; set; }
    [EmailAddress]
    public string StylistEmail { get; set; }
    public string StylistBio { get; set; }
    public DateTime HireDate { get; set; }
    public virtual ICollection<Client> Clients { get; set; }
  }
}