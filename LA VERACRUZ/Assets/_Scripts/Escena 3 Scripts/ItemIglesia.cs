using UnityEngine;

public class ItemIglesia : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    private int puntosI;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            puntosI++;
            gameManager.PuntosIglesia(puntosI);
            Destroy(this.gameObject);
        }
    }
}
