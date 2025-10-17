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
    [SerializeField] private GameObject boton;
    [SerializeField] private GameObject lore;
    [SerializeField] private UIManager _UIManager;
    [SerializeField] bool museoGanar;
    private int puntosMuseo;//los objetos recogidos para q le salga el boton de interactuar en el museo

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

            if (lore.activeSelf) //desactivar
            {
                lore.SetActive(false);
            }
            else // activar
            {
                lore.SetActive(true);
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
