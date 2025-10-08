using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagaer : MonoBehaviour
{
    public void LoadNextScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
