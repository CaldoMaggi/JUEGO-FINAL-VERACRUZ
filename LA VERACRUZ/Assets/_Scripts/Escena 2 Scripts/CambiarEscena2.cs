using UnityEngine;

public class CambiarEscena2 : MonoBehaviour
{
    [SerializeField]
    private GameManager gameManager;
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gameManager.CargarEscena();
        }
    }
}
