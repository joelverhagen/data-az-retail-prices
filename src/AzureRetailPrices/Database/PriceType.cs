﻿namespace Knapcode.AzureRetailPrices.Database;

public record PriceType
{
    public int Id { get; set; }

    public string Value { get; set; } = null!;
}
