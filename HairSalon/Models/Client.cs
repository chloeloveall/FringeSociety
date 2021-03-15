using System.ComponentModel.DataAnnotations;

namespace HairSalon.Models
{
  public class Client
  {
    public int ClientId { get; set; }
    [Required]
    [Display(Name="Name")]
    public string ClientName { get; set; }
    [Required]
    [DataType(DataType.PhoneNumber)]
    [Display(Name="Phone")]
    [RegularExpression(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{3})[-. ]?([0-9]{4})$", ErrorMessage = "Not a valid phone number")]
    public string ClientPhone { get; set; }
    [Required]
    [EmailAddress]
    [Display(Name="Email")]
    public string ClientEmail { get; set; }
    [Required]
    [Display(Name="Street Address")]
    public string ClientAddress { get; set; }
    [Required]
    [Display(Name="City")]
    public string ClientCity { get; set; }
    [Required]
    [Display(Name="State")]
    public ClientState ClientState { get; set; }
    [Required]
    [Display(Name="Postal Code")]
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