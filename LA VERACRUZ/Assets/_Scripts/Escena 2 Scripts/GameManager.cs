using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;
public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }
    }

    [SerializeField]private Animator transition;
    [SerializeField] private float transitionTime = 1f;
    [SerializeField] private GameObject botonM;
    [SerializeField] private GameObject loreM;
    [SerializeField] private GameObject botonI;
    [SerializeField] private GameObject loreI;
    [SerializeField] private UIManager _UIManager;
    [SerializeField] bool museoGanar;
    private int puntosMuseo;//los objetos recogidos para q le salga el boton de interactuar en el museo
    private int puntosIglesia;//los objetos recogidos para q le salga el boton de interactuar en la iglesia

    public void PuntosIglesia(int puntosI)
    {
        puntosIglesia += puntosI;
        if (puntosIglesia == 5)
        {
            if (botonI.activeSelf) //desactivar
            {
                botonI.SetActive(false);
            }
            else // activar
            {
                botonI.SetActive(true);
            }

            if (loreI.activeSelf) //desactivar
            {
                loreI.SetActive(false);
            }
            else // activar
            {
                loreI.SetActive(true);
            }
        }
    }
    public void PuntosMuseo(int puntosM)
    {
        puntosMuseo += puntosM;
        if (puntosMuseo == 4)
        {
            if (botonM.activeSelf) //desactivar
            {
                botonM.SetActive(false);
            }
            else // activar
            {
                botonM.SetActive(true);
            }

            if (loreM.activeSelf) //desactivar
            {
                loreM.SetActive(false);
            }
            else // activar
            {
                loreM.SetActive(true);
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
