﻿namespace Knapcode.AzureRetailPrices.Reflection;

/// <summary>
/// Source: https://stackoverflow.com/a/26733318
/// </summary>
public interface IPropertyCallAdapter<TThis>
{
    object? InvokeGet(TThis @this);
}
