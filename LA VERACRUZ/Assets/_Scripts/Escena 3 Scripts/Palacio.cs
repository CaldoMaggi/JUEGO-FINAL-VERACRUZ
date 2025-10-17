using UnityEngine;
using UnityEngine.SceneManagement;

public class Palacio : MonoBehaviour
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
        if (dentro && (Input.GetKeyDown(KeyCode.F) || Input.GetKeyDown(KeyCode.E)))
        {
            SceneManager.LoadScene("P_DE LA CULTURA"); // cambia el nombre de la escena
        }
    }
}
