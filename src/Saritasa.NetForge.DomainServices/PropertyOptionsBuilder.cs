﻿using Saritasa.NetForge.Domain.Entities.Options;
using Saritasa.NetForge.Domain.Enums;

namespace Saritasa.NetForge.DomainServices;

/// <summary>
/// Builder class for configuring entity's property options.
/// </summary>
public class PropertyOptionsBuilder
{
    private readonly PropertyOptions options = new();

    /// <summary>
    /// Creates property options.
    /// </summary>
    /// <param name="propertyName">Property name to create options for.</param>
    /// <returns>Property options.</returns>
    public PropertyOptions Create(string propertyName)
    {
        options.PropertyName = propertyName;

        return options;
    }

    /// <summary>
    /// Sets whether the property should be hidden from the view.
    /// </summary>
    public PropertyOptionsBuilder SetIsHidden(bool isHidden)
    {
        options.IsHidden = isHidden;
        return this;
    }

    /// <summary>
    /// Sets new display name to property.
    /// </summary>
    /// <param name="displayName">Name to display.</param>
    public PropertyOptionsBuilder SetDisplayName(string displayName)
    {
        options.DisplayName = displayName;
        return this;
    }

    /// <summary>
    /// Sets description to property.
    /// </summary>
    /// <param name="description">Description.</param>
    public PropertyOptionsBuilder SetDescription(string description)
    {
        options.Description = description;
        return this;
    }

    /// <summary>
    /// Sets order to property.
    /// </summary>
    /// <param name="order">Order number.</param>
    public PropertyOptionsBuilder SetOrder(int order)
    {
        options.Order = order;
        return this;
    }

    /// <summary>
    /// Sets search type to property.
    /// </summary>
    public PropertyOptionsBuilder SetSearchType(SearchType searchType)
    {
        options.SearchType = searchType;
        return this;
    }
}
