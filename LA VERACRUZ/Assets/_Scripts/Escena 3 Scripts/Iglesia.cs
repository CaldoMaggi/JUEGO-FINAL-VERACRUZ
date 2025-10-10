using UnityEngine;
using UnityEngine.SceneManagement;

public class Iglesia : MonoBehaviour
{
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            //si presiona E carga la escena 4
            SceneManager.LoadScene(4);
        }
    }
}
