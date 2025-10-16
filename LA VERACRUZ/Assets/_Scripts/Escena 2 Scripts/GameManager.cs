using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
public class GameManager : MonoBehaviour
{
    [SerializeField]private Animator transition;
    [SerializeField] private float transitionTime = 1f;
    [SerializeField] private GameObject boton;
    [SerializeField] private UIManager _UIManager;
    private int puntosMuseo;

    public void PuntosMuseo(int puntos)
    {
        puntosMuseo += puntos;
        if (puntosMuseo == 4)
        {
            if (boton.activeSelf) //desactivar
            {
                boton.SetActive(false);
            }
            else // activar
            {
                boton.SetActive(true);
            }
        }
    }

    public void CargarEscena()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }
    IEnumerator LoadLevel(int levelIndex)
    {
        //poner la animacion
        transition.SetTrigger("Start");
        //esperar
        yield return new WaitForSeconds(transitionTime);
        //cargar la escena
        SceneManager.LoadScene(levelIndex);
    }
    public void SalirJuego()
    {
        Application.Quit();
    }

}
