using UnityEngine;
using UnityEngine.SceneManagement;

public class ProstitutaFinal : MonoBehaviour
{
    [Header("Paneles y UI")]
    [SerializeField] private GameObject panelDialogo;
    [SerializeField] private GameObject textoDialogo;
    [SerializeField] private GameObject botonSi;
    [SerializeField] private GameObject botonNo;

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
        Time.timeScale = 0f;
    }

    void OcultarDialogo()
    {
        dialogoActivo = false;
        if (panelDialogo != null) panelDialogo.SetActive(false);
        if (textoDialogo != null) textoDialogo.SetActive(false);
        if (botonSi != null) botonSi.SetActive(false);
        if (botonNo != null) botonNo.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Salvarla()
    {
        Time.timeScale = 1f;
        Debug.Log("Final bueno activado");
        SceneManager.LoadScene(6); // Cambia este número por el índice real de FINAL BUENO
    }

    public void Ignorarla()
    {
        Time.timeScale = 1f;
        Debug.Log("Final malo activado");
        SceneManager.LoadScene(7); // Cambia este número por el índice real de FINAL MALO
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
            jugadorCerca = true;
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
