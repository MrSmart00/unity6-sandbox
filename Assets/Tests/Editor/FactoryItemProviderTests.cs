using System;
using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Assert = UnityEngine.Assertions.Assert;
using Random = UnityEngine.Random;

public class FactoryItemProviderTests
{
    FactoryItemProvider provider = new FactoryItemProvider();

    [SetUp]
    public void Setup()
    {
        Random.InitState(1);
    }

    [Test]
    public void ProviderTests()
    {
        Assert.AreEqual(FactoryItemType.Capsule, Enum.Parse(typeof(FactoryItemType),  provider.Generate().name));
        Assert.AreEqual(FactoryItemType.Capsule, Enum.Parse(typeof(FactoryItemType),  provider.Generate().name));
        Assert.AreEqual(FactoryItemType.Capsule, Enum.Parse(typeof(FactoryItemType),  provider.Generate().name));
        Assert.AreEqual(FactoryItemType.Capsule, Enum.Parse(typeof(FactoryItemType),  provider.Generate().name));
        Assert.AreEqual(FactoryItemType.Cube, Enum.Parse(typeof(FactoryItemType),  provider.Generate().name));
        Assert.AreEqual(FactoryItemType.Sphere, Enum.Parse(typeof(FactoryItemType),  provider.Generate().name));
        Assert.AreEqual(FactoryItemType.Cylinder, Enum.Parse(typeof(FactoryItemType),  provider.Generate().name));
        Assert.AreEqual(FactoryItemType.Sphere, Enum.Parse(typeof(FactoryItemType),  provider.Generate().name));
        Assert.AreEqual(FactoryItemType.Cylinder, Enum.Parse(typeof(FactoryItemType),  provider.Generate().name));
        Assert.AreEqual(FactoryItemType.Sphere, Enum.Parse(typeof(FactoryItemType),  provider.Generate().name));
        Assert.AreEqual(FactoryItemType.Cylinder, Enum.Parse(typeof(FactoryItemType),  provider.Generate().name));
        Assert.AreEqual(FactoryItemType.Cylinder, Enum.Parse(typeof(FactoryItemType),  provider.Generate().name));
    }
}
