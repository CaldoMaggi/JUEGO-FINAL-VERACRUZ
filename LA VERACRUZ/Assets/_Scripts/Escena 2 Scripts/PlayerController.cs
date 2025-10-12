using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    //Solo moverá el personaje de izquierda a derecha
    [SerializeField] private float speed = 5f;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private Animator animator;
    [SerializeField] private float jumpForce = 7f;

    private Rigidbody2D rb;
    private bool isGrounded = true;
    private bool canJump = false; // 🔹 Solo se activa en ciertas escenas

    private Vector2 movement;
    private float xPosition;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        // 🔹 Detectar si la escena actual permite salto
        string currentScene = SceneManager.GetActiveScene().name;
        if (currentScene == "IGLESIA (4)" || currentScene == "M_ANTIOQUIA(5)")
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

    void Jump()
    {
        if (canJump && isGrounded && Input.GetKeyDown(KeyCode.UpArrow))
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
            isGrounded = false;
            animator.SetTrigger("Jump");
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

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Piso"))
        {
            isGrounded = true;
        }
    }
}
