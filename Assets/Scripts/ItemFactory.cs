using Unity.VisualScripting;
using UnityEngine;

public class ItemFactory : MonoBehaviour
{
    private FactoryItemProvider provider = new FactoryItemProvider();
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    async void Update()
    {
        if(Input.GetMouseButtonDown(0)) {
            await InstantiateAsync(
                provider.Generate(), 
                BallParameter.GeneratePosition(), 
                Quaternion.identity
            );
        }
    }
}
