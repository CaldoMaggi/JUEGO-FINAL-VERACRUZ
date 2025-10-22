using UnityEngine;

public class ItemsPalacio : MonoBehaviour
{
    [SerializeField] private GM_Palacio gameManager;
    private int puntosI;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            puntosI++;
            gameManager.PuntosPalacio(puntosI);
            Destroy(this.gameObject);
        }
    }
}
