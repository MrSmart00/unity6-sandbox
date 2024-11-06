using System.Collections;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using Assert = UnityEngine.Assertions.Assert;

public class BallParameterTests
{
    [SetUp]
    public void Setup()
    {
        Random.InitState(1);
    }

    // A Test behaves as an ordinary method
    [Test]
    public void GenerateColorTest()
    {
        var color = BallParameter.GenerateColor();
        Assert.AreEqual(new Color(0f, 0.226f, 0.319f), color);

        color = BallParameter.GenerateColor();
        Assert.AreEqual(new Color(0.540f, 0.406f, 0.215f), color);
    }

    [Test]
    public void GenerateScaleTest()
    {
        var scale = BallParameter.GenerateScale();
        Assert.AreEqual(new Vector3(1.00f, 1.00f, 1.00f), scale);
    }

    [Test]
    public void GeneratePositionTest()
    {
        var position = BallParameter.GeneratePosition();
        Debug.Log($"{position}");
        Assert.AreEqual(new Vector3(-1f, 10, -0.55f), position);
    }
}
