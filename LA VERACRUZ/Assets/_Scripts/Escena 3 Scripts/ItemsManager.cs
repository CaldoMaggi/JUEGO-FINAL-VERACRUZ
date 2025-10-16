using UnityEngine;

public class ItemsManager : MonoBehaviour
{
    [SerializeField] private GameManager gameManager;
    private int puntos;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            puntos++;
            gameManager.PuntosMuseo(puntos);
            Destroy(this.gameObject);
        }
    }
}
