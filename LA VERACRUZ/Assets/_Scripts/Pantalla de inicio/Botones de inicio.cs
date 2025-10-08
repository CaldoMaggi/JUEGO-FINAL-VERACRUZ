using UnityEngine;

public class Botonesdeinicio : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager;

    public void IniciarJuego()
    {
        gameManager.CargarEscena();
    }
    public void SalirJuego()
    {
        Application.Quit();
    }

}
