using UnityEngine;
using UnityEngine.UI;

public class LoreNoche1 : MonoBehaviour
{
    [SerializeField] private GameObject canvas3;
    [SerializeField] private bool dentro;
    [SerializeField] private UIManager _UIManager;
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag("Player")) dentro = true;
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if (col.CompareTag("Player")) dentro = true;
    }
    public void Update()
    {
        if (dentro && Input.GetKeyDown(KeyCode.F))
        {
            if (canvas3.activeSelf) //desactivar
            {
                _UIManager.EstadoDeJuego("PeriodicoMuseo");
            }
            else // activar
            {
                _UIManager.EstadoDeJuego("PeriodicoMuseo");
            }
        }
    }
}