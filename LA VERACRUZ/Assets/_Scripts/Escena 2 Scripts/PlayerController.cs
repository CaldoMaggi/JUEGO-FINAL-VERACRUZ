using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    //Solo moverá el personaje de izquierda a derecha
    [SerializeField] private float speed = 5f;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Animator animator;
    [SerializeField] private float jumpForce = 6f;
    [SerializeField] private Rigidbody2D rb2d;
    private bool isGrounded = true;
    private bool canJump = false; // 🔹 Solo se activa en ciertas escenas
    private Vector2 movement;
    private float xPosition;

    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();

        // 🔹 Detectar si la escena actual permite salto HAY QUE CAMBIARLO A SWITCH
        string currentScene = SceneManager.GetActiveScene().name;
        if (currentScene == "IGLESIA (4)")
        {
            canJump = true;
        }
        else if (currentScene == "M_ANTIOQUIA(5)")
        {
            canJump = true;
        }
        else if (currentScene == "P_DE LA CULTURA")
        {
            canJump = true;
        }
        else
        {
            canJump = false; // En el mundo normal no salta
        }
    }
    void Update()
    {
        HandleMovement();
        FlipCharacter();
        Jump();
    }
    private void HandleMovement()
    {
        //movimiento del jugador
        float input = Input.GetAxis("Horizontal");
        movement.x = input * speed * Time.deltaTime;
        transform.Translate(movement);
        if(input != 0)
        {
            animator.SetBool("isRunning", true);
        }
        else
        {
            animator.SetBool("isRunning", false);
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Piso"))
        {
            isGrounded = true;
        }
    }

    void Jump()
    {
        if (canJump && isGrounded && Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb2d.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse); //salto
            isGrounded = false; // Evita saltos dobles
        }
    }

    private void FlipCharacter()
    {
        float input = Input.GetAxis("Horizontal");
        if (input > 0 && (transform.position.x > xPosition))
        {
            //se mueve a la derecha y voltea el sprite
            spriteRenderer.flipX = false;
        }
        else if(input < 0 && (transform.position.x < xPosition))
        {
            //se mueve a la izquierda y voltea el sprite
            spriteRenderer.flipX = true;
        }
        xPosition = transform.position.x;
    }
}
