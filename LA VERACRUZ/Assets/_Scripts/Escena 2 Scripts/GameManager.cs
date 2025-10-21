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

    [SerializeField] private Animator transition;
    [SerializeField] private float transitionTime = 1f;
    [SerializeField] private GameObject botonM;
    [SerializeField] private GameObject loreM;
    [SerializeField] private GameObject botonI;
    [SerializeField] private GameObject loreI;
    [SerializeField] private UIManager _UIManager;
    [SerializeField] private bool museoGanar;

    private int puntosMuseo;
    private int puntosIglesia;

    // ----------- PROGRESO DE LOS LUGARES ------------
    public void PuntosIglesia(int puntosI)
    {
        puntosIglesia += puntosI;
        if (puntosIglesia == 5)
        {
            botonI.SetActive(!botonI.activeSelf);
            loreI.SetActive(!loreI.activeSelf);
        }
    }

    public void PuntosMuseo(int puntosM)
    {
        puntosMuseo += puntosM;
        if (puntosMuseo == 4)
        {
            botonM.SetActive(!botonM.activeSelf);
            loreM.SetActive(!loreM.activeSelf);
        }
    }

    // ----------- CAMBIO DE ESCENAS ------------
    public void CargarEscena()
    {
        StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    IEnumerator LoadLevel(int levelIndex)
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(levelIndex);
    }

    public void SalirJuego()
    {
        Application.Quit();
    }

    // ----------- FINALES ------------
    [Header("Final Malo")]
    public bool laberintoFallido = false;
    [SerializeField] private string escenaFinalMalo = "FinalMalo";

    [Header("Final Bueno")]
    public bool finalBuenoDesbloqueado = false;
    [SerializeField] private string escenaFinalBueno = "FinalBueno";

    public void RegistrarFalloLaberinto()
    {
        laberintoFallido = true;
        RevisarFinal();
    }

    public void RegistrarFinalBueno()
    {
        finalBuenoDesbloqueado = true;
        RevisarFinal();
    }

    private void RevisarFinal()
    {
        if (laberintoFallido)
        {
            StartCoroutine(CargarFinalMalo());
        }
        else if (finalBuenoDesbloqueado)
        {
            StartCoroutine(CargarFinalBueno());
        }
    }

    private IEnumerator CargarFinalMalo()
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(escenaFinalMalo);
    }

    private IEnumerator CargarFinalBueno()
    {
        transition.SetTrigger("Start");
        yield return new WaitForSeconds(transitionTime);
        SceneManager.LoadScene(escenaFinalBueno);
    }
}
