﻿namespace ExtraIsland.Components;

// ReSharper disable once ClassNeverInstantiated.Global
public class BetterCountdownConfig {
    public string? TargetDate { get; set; }
    public string? Prefix { get; set; }
    public string? Suffix { get; set; }
    public bool? IsSystemTime { get; set; }
}

enum CountdownAccuracy {
    Day,
    Hour,
    Minute,
    Second,
}