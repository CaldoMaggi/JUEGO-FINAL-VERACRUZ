using UnityEngine;

public class ItemsManager : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
           
            Destroy(this.gameObject);
        }
    }
}
