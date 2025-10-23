using UnityEngine;
using UnityEngine.UI;

public class LoreMuseo : MonoBehaviour
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
            print("ganaste museo");

            if (canvas3.activeSelf) //desactivar
            {
                GM_Final.Instance.CompletarMinijuego(3);
                _UIManager.EstadoDeJuego("PeriodicoMuseo");
            }
            else // activar
            {
                _UIManager.EstadoDeJuego("PeriodicoMuseo");
            }
        }
    }
}