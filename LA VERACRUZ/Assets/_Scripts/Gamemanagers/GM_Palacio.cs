using UnityEngine;

public class GM_Palacio : MonoBehaviour
{
    [SerializeField] private GameObject botonP;
    [SerializeField] private GameObject loreP;
    private int puntospalacio;
    public void PuntosPalacio(int puntosI)
    {
        puntospalacio += puntosI;
        if (puntospalacio == 5)
        {
            botonP.SetActive(!botonP.activeSelf);
            loreP.SetActive(!loreP.activeSelf);
        }
    }

}
