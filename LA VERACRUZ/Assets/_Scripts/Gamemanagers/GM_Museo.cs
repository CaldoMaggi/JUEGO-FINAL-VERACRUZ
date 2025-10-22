using Unity.VisualScripting.Dependencies.Sqlite;
using UnityEngine;

public class GM_Museo : MonoBehaviour
{
    [SerializeField] private GameObject botonM;
    [SerializeField] private GameObject loreM;
    private int puntosMuseo;
    public void PuntosMuseo(int puntosM)
    {
        puntosMuseo += puntosM;
        if (puntosMuseo == 4)
        {
            botonM.SetActive(!botonM.activeSelf);
            loreM.SetActive(!loreM.activeSelf);
        }
    }
}
