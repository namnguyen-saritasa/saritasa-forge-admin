﻿using Saritasa.NetForge.Demo.Net7.Constants;
using Saritasa.NetForge.Domain.Attributes;
using System.ComponentModel;

namespace Saritasa.NetForge.Demo.Net7.Models;

/// <summary>
/// Represents a shop entity.
/// </summary>
[NetForgeEntity(GroupName = GroupConstants.Shops)]
public class Shop
{
    /// <summary>
    /// Unique identifier for the shop.
    /// </summary>
    [Description("Shop identifier.")]
    [DisplayName("Identifier")]
    public int Id { get; set; }

    /// <summary>
    /// The name of the shop.
    /// </summary>
    [Description("Shop name.")]
    [NetForgeProperty(IsSortable = true)]
    public required string Name { get; set; }

    /// <summary>
    /// The address of the shop.
    /// </summary>
    public Address? Address { get; set; }

    /// <summary>
    /// The date when the shop was opened.
    /// </summary>
    public DateTime OpenedDate { get; set; }

    /// <summary>
    /// The total sales amount for the shop.
    /// </summary>
    [NetForgeProperty(DisplayName = "Sales", Description = "Total sales.", IsSortable = true)]
    public decimal TotalSales { get; set; }

    /// <summary>
    /// The shop is currently open for business.
    /// </summary>
    public bool IsOpen { get; set; }

    /// <summary>
    /// The list of products available in the shop.
    /// </summary>
    public List<Product> Products { get; set; } = new();

    /// <summary>
    /// The shop owner's contact information.
    /// </summary>
    public ContactInfo? OwnerContact { get; set; }
}

