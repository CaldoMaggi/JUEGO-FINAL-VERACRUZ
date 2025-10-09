using UnityEngine;
using UnityEngine.UI;

public class TextoPeriodico : MonoBehaviour
{
    [SerializeField] private GameObject canvas;
    private bool isVisible = false;  // Estado inicial: oculto

    void Start()
    {
        // Aseg�rate de que empiece oculto (opcional)
        canvas.SetActive(isVisible);
    }
    void Update()
    {
        // Detecta si se presion� la tecla E en este frame
        if (Input.GetKeyDown(KeyCode.E))
        {
            // Cambia el estado
            isVisible = !isVisible;

            // Activa o desactiva el Canvas
            canvas.SetActive(isVisible);
        }
    }
}
