using System;
using System.Web;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HairSalon.Models
{
  public class Client
  {
    public int ClientId { get; set; }
    [Required]
    public string ClientName { get; set; }
    [Required]
    [DataType(DataType.PhoneNumber)]
    [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
    public string ClientPhone { get; set; }
    [Required]
    [EmailAddress]
    public string ClientEmail { get; set; }
    [Required]
    public string ClientAddress { get; set; }
    [Required]
    public string ClientCity { get; set; }
    [Required]
    public ClientState ClientState { get; set; }
    [Required]
    public int ClientZip { get; set; }
    public int StylistId { get; set; }
    public virtual Stylist Stylist { get; set; }
  }

  public enum ClientState
  {
    AL,
    AK,
    AS,
    AZ,
    AR,
    CA,
    CO,
    CT,
    DE,
    DC,
    FL,
    GA,
    GU,
    HI,
    ID,
    IL,
    IN,
    IA,
    KS,
    KY,
    LA,
    ME,
    MD,
    MA,
    MI,
    MN,
    MS,
    MO,
    MT,
    NE,
    NV,
    NH,
    NJ,
    NM,
    NY,
    NC,
    ND,
    OH,
    OK,
    OR,
    PA,
    PR,
    RI,
    SC,
    SD,
    TN,
    TX,
    UT,
    VT,
    VA,
    VI,
    WA,
    WV,
    WI,
    WY
  }
}