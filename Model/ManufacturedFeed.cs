﻿using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;
using BirdsCo.Enums;

namespace BirdsCo.Model;

public class ManufacturedFeed :  MainFarmBase
{
    public string FeedBrand { get; set; } = "";
    
    public eFeedType FeedType { get; set; }

    [DisplayName("Weight Per Bag")]
    public eAmount FeedWeightPerBag { get; set; }

    [DisplayName("Total number of Bags")]
    public int FeedCount { get; set; }

    public bool IsFeedFinished { get; set; }

    public DateOnly DateOfProcurement { get; set; }

    [ForeignKey(nameof(LiveStockFeedGuid))]
    public Guid LiveStockFeedGuid { get; set; }

}
