using UnityEngine;
using UnityEngine.UI;

public class TextoPeriodico : MonoBehaviour
{
    [SerializeField] private GameObject canvas;
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
        if (dentro && (Input.GetKeyDown(KeyCode.E) || Input.GetKeyDown(KeyCode.F)))
        {
            if (canvas.activeSelf) //desactivar
            {
                _UIManager.EstadoDeJuego("Periodico1");
            }
            else // activar
            {
                _UIManager.EstadoDeJuego("Periodico1");
            }
        }
    }
}
  
