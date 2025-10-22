using UnityEngine;

public class CambiarEscena2 : MonoBehaviour
{
    [SerializeField]
    private GM_Inicio gameManager;
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            gameManager.CargarEscena();
        }
    }
}
