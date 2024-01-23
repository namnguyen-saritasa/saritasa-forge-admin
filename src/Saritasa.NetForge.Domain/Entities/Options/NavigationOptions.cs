﻿using Saritasa.NetForge.Domain.Entities.Metadata;

namespace Saritasa.NetForge.Domain.Entities.Options;

/// <summary>
/// Navigation options.
/// </summary>
public class NavigationOptions
{
    /// <inheritdoc cref="PropertyMetadataBase.Name"/>
    public string PropertyName { get; set; } = string.Empty;

    /// <summary>
    /// Property options for the navigation properties.
    /// </summary>
    public ICollection<PropertyOptions> PropertyOptions { get; set; } = new List<PropertyOptions>();
}
