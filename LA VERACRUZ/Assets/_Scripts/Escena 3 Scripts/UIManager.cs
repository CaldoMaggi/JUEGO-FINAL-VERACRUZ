using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject canvas;
    [SerializeField] private GameObject canvasMuseo;
    [SerializeField] private GameObject canvasIglesia;
    [SerializeField] private GameObject canvasPalacio;
    public void EstadoDeJuego(string estado)
    {
        switch (estado)
        {
            case "Ganaste":
                SceneManager.LoadScene(3);
                break;

            case "Periodico1":
                if (canvas.activeSelf) //desactivar
                {
                    canvas.SetActive(false);
                }
                else // activar
                {
                    canvas.SetActive(true);
                }
                break;

            case "PeriodicoMuseo":
                if (canvasMuseo.activeSelf) //desactivar
                {
                    canvasMuseo.SetActive(false);
                }
                else // activar
                {
                    canvasMuseo.SetActive(true);
                }
                break;

            case "Salir":
                Application.Quit();
                break;
        }
    }
}
