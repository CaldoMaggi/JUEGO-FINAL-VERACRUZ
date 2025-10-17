using UnityEngine;

public class LoreNoche1 : MonoBehaviour
{
    [SerializeField] private GameObject canvas1;
    [SerializeField] private GameObject canvas2;
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
    public void LoreMuseo()
    {
        if (dentro && (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.F)))
        {
            if (canvas3.activeSelf) //desactivar
            {
                _UIManager.EstadoDeJuego("Periodico4");
            }
            else // activar
            {
                _UIManager.EstadoDeJuego("Periodico4");
            }
        }
    }
}
