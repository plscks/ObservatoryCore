﻿using Observatory.Framework.Files.ParameterTypes;
using System.Text.Json.Serialization;

namespace Observatory.Framework.Files.Journal
{
    public class CargoDepot : JournalBase
    {
        public ulong MissionID { get; init; }
        public UpdateType UpdateType { get; init; }
        public string CargoType { get; init; }
        public string CargoType_Localised { get; init; }
        public int Count { get; init; }
        public ulong StartMarketID { get; init; }
        public ulong EndMarketID { get; init; }
        public int ItemsCollected { get; init; }
        public int ItemsDelivered { get; init; }
        public int TotalItemsToDeliver { get; init; }
        public float Progress { get; init; }
    }
}
