using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameScript : MonoBehaviour
{
    public void onTappedStart()
    {
        SceneManager.LoadScene("SandboxScene");
    }
}
