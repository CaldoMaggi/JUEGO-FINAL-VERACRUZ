using UnityEngine;

public class PCparaMinijuegos : MonoBehaviour
{
    public float jumpForce = 7f;
    private Rigidbody2D rb;
    private bool isGrounded;

        if(isGrounded && Input.GetKeyDown(KeyCode.UpArrow))
        {   
            rb.AddForce(Vector2.up* jumpForce, ForceMode2D.Impulse);
            Debug.log("Saltando");
        }


void Start()
    {
        // 🔹 Salto con flecha arriba
        Input.GetKeyDown(KeyCode.UpArrow);
       

        

    // 🔹 Detectar si está tocando el suelo
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Piso"))
            isGrounded = true;
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Piso"))
            isGrounded = false;
    }
}