using Microsoft.AspNetCore.Components.Forms;
using System.ComponentModel.DataAnnotations;
using System.Drawing;

namespace BirdsCo.Model;

public class Merchant : MainFarmBase
{
    [Required]
    public string MerchantName { get; set; } = "";

    [Required]
    public int MerchantPhoneNumber { get; set; }

    public string MerchantLocation { get; set; } = "";

    public required AccountNumbers[] Accounts { get; set; }

    public DayOfWeek EggPickingDate {  get; set; }
}

public class AccountNumbers : MainFarmBase
{
public int AccountNumber { get; set; }

public string AccountName { get; set; } = string.Empty;

    public string AccountBank { get; set; } = "";
}
