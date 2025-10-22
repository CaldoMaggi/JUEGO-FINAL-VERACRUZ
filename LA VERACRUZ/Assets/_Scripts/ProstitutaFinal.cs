using UnityEngine;
using UnityEngine.SceneManagement;

public class ProstitutaFinal : MonoBehaviour
{
    [Header("Paneles y UI")]
    [SerializeField] private GameObject panelDialogo;
    [SerializeField] private GameObject textoDialogo;
    [SerializeField] private GameObject botonSi;
    [SerializeField] private GameObject botonNo;

    [Header("Escenas finales (asegúrate que estén en Build Settings)")]
    [SerializeField] private string escenaFinalBueno = "FINAL BUENO";
    [SerializeField] private string escenaFinalMalo = "FINAL MALO";

    private bool jugadorCerca = false;
    private bool dialogoActivo = false;

    void Start()
    {
        if (panelDialogo != null) panelDialogo.SetActive(false);
        if (textoDialogo != null) textoDialogo.SetActive(false);
        if (botonSi != null) botonSi.SetActive(false);
        if (botonNo != null) botonNo.SetActive(false);
    }

    void Update()
    {
        if (jugadorCerca && Input.GetKeyDown(KeyCode.E) && !dialogoActivo)
        {
            MostrarDialogo();
        }
    }

    void MostrarDialogo()
    {
        dialogoActivo = true;

        if (panelDialogo != null) panelDialogo.SetActive(true);
        if (textoDialogo != null) textoDialogo.SetActive(true);
        if (botonSi != null) botonSi.SetActive(true);
        if (botonNo != null) botonNo.SetActive(true);

        Time.timeScale = 0f; // Pausa el juego
    }

    void OcultarDialogo()
    {
        dialogoActivo = false;

        if (panelDialogo != null) panelDialogo.SetActive(false);
        if (textoDialogo != null) textoDialogo.SetActive(false);
        if (botonSi != null) botonSi.SetActive(false);
        if (botonNo != null) botonNo.SetActive(false);

        Time.timeScale = 1f; // Reanuda el juego
    }

    public void Salvarla()
    {
        Time.timeScale = 1f;
        Debug.Log("Cargando FINAL BUENO...");
        SceneManager.LoadScene("FINAL BUENO");
    }

    public void Ignorarla()
    {
        Time.timeScale = 1f;
        Debug.Log("Cargando FINAL MALO...");
        SceneManager.LoadScene("FINAL MALO");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            jugadorCerca = true;
            Debug.Log("Jugador cerca de la prostituta");
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            jugadorCerca = false;
            OcultarDialogo();
        }
    }
}
