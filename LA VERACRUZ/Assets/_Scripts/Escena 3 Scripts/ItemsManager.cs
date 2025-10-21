using UnityEngine;

public class ItemsManager : MonoBehaviour
{
    private GameManager gameManager;
    private int puntosM;

    private void Start()
    {
        
        gameManager = GameManager.Instance;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.CompareTag("Player"))
        {
            puntosM++;
            gameManager.PuntosMuseo(puntosM);

           
            if (gameManager.laberintoFallido)
            {
                gameManager.RegistrarFalloLaberinto();
            }

            Destroy(gameObject);
        }
    }
}
