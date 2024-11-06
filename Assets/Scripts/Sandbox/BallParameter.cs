using UnityEngine;

public struct BallParameter
{

    public BallParameter(int seed)
    {
        Random.InitState(seed);
    }

    public static Color GenerateColor() 
    {
        return new Color(
            GenerateFloat3(), 
            GenerateFloat3(), 
            GenerateFloat3()
        );
    }

    static float GenerateFloat3()
    {
        return float.Parse(Random.Range(0f, 1f).ToString("F3"));
    }

    public static Vector3 GeneratePosition() 
    {
        return new Vector3(GeneratePositionFloat2(), 10, GeneratePositionFloat2());
    }

    static float GeneratePositionFloat2()
    {
        return float.Parse(Random.Range(-1.0f, 1.0f).ToString("F2"));
    }

    public static Vector3 GenerateScale()
    {
        var scale = GenerateScaleFloat2();
        return new Vector3(scale, scale, scale);
    }

    static float GenerateScaleFloat2()
    {
        return float.Parse(Random.Range(1, 0.2f).ToString("F2"));
    }

}
