using UnityEngine;

public class ItemsManager : MonoBehaviour
{
    private GM_Museo gameManager;
    private int puntosM;
    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.CompareTag("Player"))
        {
            puntosM++;
            gameManager.PuntosMuseo(puntosM);
        }
    }
}
