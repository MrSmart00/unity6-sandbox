using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ItemFactory : MonoBehaviour
{
    public GameObject logger;
    private int count;

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
            count++;
            logger.GetComponent<TextMeshProUGUI>().text = $"{count}";
            if (count > 100) {
                SceneChanger.onBackToStart();
            }
        }
    }
}
