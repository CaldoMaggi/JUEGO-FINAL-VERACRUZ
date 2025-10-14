using UnityEngine;
using UnityEngine.SceneManagement;

public class Museo : MonoBehaviour
{
    bool dentro;
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player")) dentro = true;
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.CompareTag("Player")) dentro = false;
    }

    void Update()
    {
        if (dentro && Input.GetKeyDown(KeyCode.F))
        {
            SceneManager.LoadScene("M_ANTIOQUIA(5)"); // cambia el nombre de la escena
        }
    }
}
