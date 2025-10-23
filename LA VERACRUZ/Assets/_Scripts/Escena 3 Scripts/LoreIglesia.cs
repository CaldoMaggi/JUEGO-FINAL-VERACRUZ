using UnityEngine;
using UnityEngine.UI;

public class LoreIglesia : MonoBehaviour
{
    [SerializeField] private GameObject canvasI;
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
            print("ganaste iglesia");

            if (canvasI.activeSelf) //desactivar
            {
                GM_Final.Instance.CompletarMinijuego(1);
                _UIManager.EstadoDeJuego("PeriodicoIglesia");
            }
            else // activar
            {

                _UIManager.EstadoDeJuego("PeriodicoIglesia");
            }
        }
    }
}
