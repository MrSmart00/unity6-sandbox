using UnityEngine;
using System;
using Random = UnityEngine.Random;

public class FactoryItemProvider
{
    FactoryItemType GenerateType()
    {
        var rand = Random.Range(0, Enum.GetValues(typeof(FactoryItemType)).Length);
        return (FactoryItemType) rand;
    }

    public GameObject Generate()
    {
        var obj = (GameObject)Resources.Load(GenerateType().ToString());
        obj.transform.localScale = BallParameter.GenerateScale();
        return obj;
    }
}
