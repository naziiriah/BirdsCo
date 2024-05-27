using BirdsCo.Enums;
using Microsoft.Build.Framework;
using System.ComponentModel.DataAnnotations.Schema;
using System.Transactions;

namespace BirdsCo.Model;

public class Transaction : MainFarmBase
{
    public string? Reference { get; set; }
    public int CratesSold { get; set; }
    public int ServiceFee { get; set; }

    [Required]
    public required Merchant Merchant { get; set; }
    public DateTime TransactionDate { get; set; }
    public ePaymentMethods PaymentMethod { get; set; }
}
