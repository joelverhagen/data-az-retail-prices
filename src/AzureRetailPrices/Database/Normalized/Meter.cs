﻿namespace Knapcode.AzureRetailPrices.Database.Normalized;

public record Meter
{
    public int Id { get; set; }

    public string MeterId { get; set; } = null!;
    public int UnitOfMeasureId { get; set; }
    public UnitOfMeasure UnitOfMeasure { get; set; } = null!;
}