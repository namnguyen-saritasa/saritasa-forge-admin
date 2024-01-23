﻿using Saritasa.NetForge.Domain.Entities.Metadata;

namespace Saritasa.NetForge.UseCases.Metadata.GetEntityById;

/// <summary>
/// DTO for <see cref="EntityMetadata"/>.
/// </summary>
public record GetEntityByIdDto
{
    /// <inheritdoc cref="EntityMetadata.Id"/>
    public Guid Id { get; set; }

    /// <inheritdoc cref="EntityMetadata.DisplayName"/>
    public string DisplayName { get; set; } = string.Empty;

    /// <inheritdoc cref="EntityMetadata.PluralName"/>
    public string PluralName { get; set; } = string.Empty;

    /// <inheritdoc cref="EntityMetadata.StringId"/>
    public string StringId { get; set; } = string.Empty;

    /// <inheritdoc cref="EntityMetadata.Description"/>
    public string Description { get; set; } = string.Empty;

    /// <inheritdoc cref="EntityMetadata.ClrType"/>
    public Type? ClrType { get; set; }

    /// <inheritdoc cref="EntityMetadata.Properties"/>
    public ICollection<PropertyMetadataDto> Properties { get; set; } = new List<PropertyMetadataDto>();

    /// <inheritdoc cref="EntityMetadata.Navigations"/>
    public ICollection<NavigationMetadataDto> Navigations { get; set; } = new List<NavigationMetadataDto>();

    /// <inheritdoc cref="EntityMetadata.SearchFunction"/>
    public Func<IServiceProvider?, IQueryable<object>, string, IQueryable<object>>? SearchFunction { get; set; }

    /// <inheritdoc cref="EntityMetadata.CustomQueryFunction"/>
    public Func<IServiceProvider?, IQueryable<object>, IQueryable<object>>? CustomQueryFunction { get; set; }
}
