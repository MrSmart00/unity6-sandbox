using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Assert = UnityEngine.Assertions.Assert;

public class FactoryItemProviderTests
{
    [SetUp]
    public void Setup()
    {
        Random.InitState(1);
    }

    [Test]
    public void ProviderTests()
    {
        Assert.AreEqual(FactoryItemType.Capsule, FactoryItemProvider.Generate());
        Assert.AreEqual(FactoryItemType.Capsule, FactoryItemProvider.Generate());
        Assert.AreEqual(FactoryItemType.Capsule, FactoryItemProvider.Generate());
        Assert.AreEqual(FactoryItemType.Capsule, FactoryItemProvider.Generate());
        Assert.AreEqual(FactoryItemType.Capsule, FactoryItemProvider.Generate());
        Assert.AreEqual(FactoryItemType.Capsule, FactoryItemProvider.Generate());
        Assert.AreEqual(FactoryItemType.Capsule, FactoryItemProvider.Generate());
        Assert.AreEqual(FactoryItemType.Capsule, FactoryItemProvider.Generate());
        Assert.AreEqual(FactoryItemType.Cube, FactoryItemProvider.Generate());
        Assert.AreEqual(FactoryItemType.Sphere, FactoryItemProvider.Generate());
        Assert.AreEqual(FactoryItemType.Sphere, FactoryItemProvider.Generate());
        Assert.AreEqual(FactoryItemType.Cylinder, FactoryItemProvider.Generate());
    }
}
