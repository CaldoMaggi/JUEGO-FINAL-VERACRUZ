using UnityEngine;

public class LorePalacio : MonoBehaviour
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
        if (col.CompareTag("Player")) dentro = false;
    }
    public void Update()
    {
        if (dentro && (Input.GetKeyDown(KeyCode.F) || Input.GetKeyDown(KeyCode.E)))
        {
            if (canvas3.activeSelf) //desactivar
            {
                _UIManager.EstadoDeJuego("PeriodicoPalacio");
            }
            else // activar
            {
                _UIManager.EstadoDeJuego("PeriodicoPalacio");
            }
        }
    }
}
