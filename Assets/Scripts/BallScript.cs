using UnityEngine;

public class BallScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GetComponent<Renderer>().material.color = BallParameter.GenerateColor();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
