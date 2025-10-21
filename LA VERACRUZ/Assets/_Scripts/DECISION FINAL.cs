using UnityEngine;

public class DECISIONFINAL : MonoBehaviour
{
    public GameObject panelFinalBueno;
    public GameObject panelFinalMalo;

    public void ElegirSi()
    {
        panelFinalBueno.SetActive(true);
    }

    public void ElegirNo()
    {
        panelFinalMalo.SetActive(true);
    }
}
