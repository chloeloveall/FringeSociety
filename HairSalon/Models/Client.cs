using System;
using System.Web;

namespace HairSalon.Models
{
  public class Client
  {
    public int ClientId { get; set; }
    public string ClientName { get; set; }
    public string ClientPhone { get; set; }
    public string ClientEmail { get; set; }
    public string ClientAddress { get; set; }
    public string ClientCity { get; set; }
    public ClientState ClientState { get; set; }
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