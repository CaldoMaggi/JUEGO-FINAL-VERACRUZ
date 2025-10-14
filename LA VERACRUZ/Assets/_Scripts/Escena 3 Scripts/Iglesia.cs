using UnityEngine;
using UnityEngine.SceneManagement;

public class Iglesia : MonoBehaviour
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
        if (dentro && Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene("IGLESIA (4)"); // cambia el nombre de la escena
        }
    }
}
