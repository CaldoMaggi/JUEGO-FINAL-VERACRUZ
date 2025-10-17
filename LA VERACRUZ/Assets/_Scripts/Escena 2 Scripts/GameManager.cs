using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
public class GameManager : MonoBehaviour
{
    [SerializeField]private Animator transition;
    [SerializeField] private float transitionTime = 1f;
    [SerializeField] private GameObject boton;
    [SerializeField] private GameObject candadoMuseo; //el sprite del candado
    [SerializeField] private UIManager _UIManager;
    [SerializeField] bool museoGanar;
    private int puntosMuseo;//los objetos recogidos para q le salga el boton de interactuar en el museo
    public object GameProgress { get; private set; }//
    public void GanarMuseo(bool estado)
    {
        museoGanar = estado;
        print("Llamando a GanarMuseo con estado: " + estado);

        if (museoGanar == true)
        {
            if (candadoMuseo != null)
            {
                Destroy(candadoMuseo);
            }
            print("Has ganado el minijuego del museo");
            Destroy(candadoMuseo);
        }
    }

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
