using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
    [SerializeField]private GameObject canvas;
    [SerializeField] private GameObject canvas1;
    [SerializeField] private GameObject canvas2;
    [SerializeField] private GameObject canvas3;
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

            case "Periodico2":
                if (canvas1.activeSelf) //desactivar
                {
                    canvas1.SetActive(false);
                }
                else // activar
                {
                    canvas1.SetActive(true);
                }
                break;

            case "Periodico3":
                if (canvas2.activeSelf) //desactivar
                {
                    canvas2.SetActive(false);
                }
                else // activar
                {
                    canvas2.SetActive(true);
                }
                break;

            case "Periodico4":
                if (canvas3.activeSelf) //desactivar
                {
                    canvas3.SetActive(false);
                }
                else // activar
                {
                    canvas3.SetActive(true);
                }
                break;

            case "Salir":
                Application.Quit();
                break;
        }
    }
}
