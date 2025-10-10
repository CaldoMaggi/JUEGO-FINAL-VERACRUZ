using UnityEngine;
using UnityEngine.SceneManagement;

public class Museo : MonoBehaviour
{
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            //si presiona E carga la escena 4
            SceneManager.LoadScene(5);
        }
    }
}
