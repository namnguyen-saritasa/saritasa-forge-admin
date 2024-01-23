﻿using Saritasa.NetForge.Domain.Entities.Metadata;

namespace Saritasa.NetForge.UseCases.Metadata.GetEntityById;

/// <summary>
/// DTO for <see cref="NavigationMetadata"/>.
/// </summary>
public class NavigationMetadataDto
{
    /// <inheritdoc cref="PropertyMetadataBase.Name"/>
    public string Name { get; set; } = string.Empty;

    /// <inheritdoc cref="NavigationMetadata.IsCollection"/>
    public bool IsCollection { get; set; }

    /// <inheritdoc cref="NavigationMetadata.TargetEntityProperties"/>
    public List<PropertyMetadataDto> TargetEntityProperties { get; set; } = new();

    /// <inheritdoc cref="NavigationMetadata.IsIncluded"/>
    public bool IsIncluded { get; set; }
}
