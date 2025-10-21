using UnityEngine;

public class ProstitutaFinal : MonoBehaviour
{
    [Header("Paneles de UI")]
    public GameObject panelDialogo;     
    public GameObject panelFinalBueno;  
    public GameObject panelFinalMalo;  

    private bool jugadorCerca = false;   
    private bool dialogoActivo = false;  

    void Update()
    {
        
        if (jugadorCerca && Input.GetKeyDown(KeyCode.E) && !dialogoActivo)
        {
            MostrarDialogo();
        }
    }

    void MostrarDialogo()
    {
        if (panelDialogo != null)
        {
            panelDialogo.SetActive(true);
            dialogoActivo = true;
            Time.timeScale = 0f; 
        }
    }

    
    public void Salvarla()
    {
        if (panelDialogo != null)
            panelDialogo.SetActive(false);

        if (panelFinalBueno != null)
            panelFinalBueno.SetActive(true);

        Time.timeScale = 1f;
        GameManager.Instance.RegistrarFinalBueno();
    }

   
    public void Ignorarla()
    {
        if (panelDialogo != null)
            panelDialogo.SetActive(false);

        if (panelFinalMalo != null)
            panelFinalMalo.SetActive(true);

        Time.timeScale = 1f; 
        GameManager.Instance.RegistrarFalloLaberinto();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
            jugadorCerca = true;
        void OnTriggerEnter2D(Collider2D other)
        {
            if (other.CompareTag("Player"))
            {
                jugadorCerca = true;
                Debug.Log("Jugador cerca de la prostituta");
            }
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
            jugadorCerca = false;
    }
}
