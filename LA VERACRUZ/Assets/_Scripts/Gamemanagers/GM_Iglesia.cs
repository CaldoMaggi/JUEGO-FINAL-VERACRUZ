using UnityEngine;

public class GM_Iglesia : MonoBehaviour
{
    [SerializeField] private GameObject botonI;
    [SerializeField] private GameObject loreI;
    private int puntosIglesia;
    public void PuntosIglesia(int puntosI)
    {
        puntosIglesia += puntosI;
        if (puntosIglesia == 5)
        {
            botonI.SetActive(!botonI.activeSelf);
            loreI.SetActive(!loreI.activeSelf);
        }
    }

}
