using Unity.VisualScripting;
using UnityEngine;

public class ItemFactory : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) {
            var type = FactoryItemProvider.Generate();
            var obj = (GameObject)Resources.Load(type.ToString());
            obj.transform.localScale = BallParameter.GenerateScale();
            Instantiate(obj, BallParameter.GeneratePosition(), Quaternion.identity);
        }
    }
}
