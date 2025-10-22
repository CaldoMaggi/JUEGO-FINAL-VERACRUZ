using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DECISIONFINAL : MonoBehaviour
{
    [Header("Paneles de Finales")]
    public GameObject panelFinalBueno;
    public GameObject panelFinalMalo;

    [Header("Texto de decisión")]
    public Text textoDecision; 
    [Header("Nombres de escenas finales")]
    public string escenaFinalBueno = "FINALBUENO";
    public string escenaFinalMalo = "FINALMALO";

    void Start()
    {
        // Mostrar el texto de opciones al iniciar
        if (textoDecision != null)
        {
            textoDecision.text = "Sálvala: F , Ignórala: G";
        }

        // Desactivar paneles al iniciar
        if (panelFinalBueno != null) panelFinalBueno.SetActive(false);
        if (panelFinalMalo != null) panelFinalMalo.SetActive(false);
    }

    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.F))
        {
            ElegirSi();
        }

        
        if (Input.GetKeyDown(KeyCode.G))
        {
            ElegirNo();
        }
    }

    public void ElegirSi()
    {
        Debug.Log("Final bueno activado");
        SceneManager.LoadScene(escenaFinalBueno);
    }

    public void ElegirNo()
    {
        Debug.Log("Final malo activado");
        SceneManager.LoadScene(escenaFinalMalo);
    }
}
