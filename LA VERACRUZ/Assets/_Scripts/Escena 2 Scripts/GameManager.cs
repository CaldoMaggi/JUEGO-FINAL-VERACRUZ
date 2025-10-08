using UnityEngine;
using UnityEngine.SceneManagement;
public class GameManager : MonoBehaviour
{
    public void CargarEscena2()
    {
        SceneManager.LoadScene(2);
    }
    public void CargarEscena()
    {
        SceneManager.LoadScene(1);
    }
}
