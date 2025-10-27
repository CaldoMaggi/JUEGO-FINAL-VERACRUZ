using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GM_Final : MonoBehaviour
{
    [SerializeField] private Animator transition;
    [SerializeField] private float transitionTime = 1f;
    public static GM_Final Instance;
    [SerializeField] private bool minijuego1Completado = false;
    [SerializeField] private bool minijuego2Completado = false;
    [SerializeField] private bool minijuego3Completado = false;
    [SerializeField] private float tiempoMaximo = 300f; // 5 minutos (en segundos)
    [SerializeField] private float tiempoTranscurrido = 0f;
    [SerializeField] private bool juegoTerminado = false;
    [SerializeField] private Image candado1;
    [SerializeField] private Image candado2;
    [SerializeField] private Image candado3;

    void Update()
    {
        // Si el juego aún no terminó, cuenta el tiempo
        if (!juegoTerminado)
        {
            tiempoTranscurrido += Time.deltaTime;

            // Si pasa el tiempo máximo sin ganar, final malo
            if (tiempoTranscurrido >= tiempoMaximo)
            {
                SceneManager.LoadScene("FINAL MALO (7)");
            }
        }
    }
    void Awake()
    {
        // Asegura que haya solo un GameManager y que persista entre escenas
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void CompletarMinijuego(int numero)
    {
        switch (numero)
        {
            case 1:
                minijuego1Completado = true;
                candado1.enabled = false;
                break;
            case 2:
                minijuego2Completado = true;
                candado2.enabled = false;
                break;
            case 3:
                minijuego3Completado = true;
                candado3.enabled = false;
                break;
        }

        VerificarGanador();
    }

    void VerificarGanador()
    {
        if (minijuego1Completado && minijuego2Completado && minijuego3Completado)
        {
            juegoTerminado = true;

            // Verifica si tardó demasiado
            if (tiempoTranscurrido <= tiempoMaximo)
                SceneManager.LoadScene("FINAL BUENO (6)");
            else
                SceneManager.LoadScene("FINAL MALO (7)");
        }

    }
  
}
