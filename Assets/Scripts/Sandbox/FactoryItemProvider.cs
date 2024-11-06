using UnityEngine;
using System;
using Random = UnityEngine.Random;

public struct FactoryItemProvider
{
    public static FactoryItemType Generate()
    {
        var rand = Random.Range(0, Enum.GetValues(typeof(FactoryItemType)).Length);
        return (FactoryItemType) rand;
    }
}
