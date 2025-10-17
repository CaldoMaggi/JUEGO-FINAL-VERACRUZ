using UnityEngine;
using UnityEngine.SceneManagement;

public class FIinalMinijuego : MonoBehaviour
{
    bool dentro;
    [SerializeField] private GameManager gameManager;
    bool museoGanar = false;
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
            museoGanar = true;
            gameManager.GanarMuseo(museoGanar);
            SceneManager.LoadScene("ESCENA 3(Noche)"); // cambia el nombre de la escena
        }
    }
}
