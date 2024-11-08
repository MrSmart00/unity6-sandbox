using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public static void onTappedStart()
    {
        SceneManager.LoadSceneAsync("SandboxScene");
    }

    public static void onBackToStart()
    {
        SceneManager.LoadSceneAsync("StartScene");
    }
}
