using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //Solo moverá el personaje de izquierda a derecha
    [SerializeField] private float speed = 5f;
    [SerializeField] private SpriteRenderer spriteRenderer;
    private Vector2 movement;
    private float xPosition;
    void Update()
    {
        HandleMovement();
        FlipCharacter();
    }
    private void HandleMovement()
    {
        float input = Input.GetAxis("Horizontal");
        movement.x = input * speed * Time.deltaTime;
        transform.Translate(movement);
    }
    private void FlipCharacter()
    {
        if(transform.position.x > xPosition)
        {
            //se mueve a la derecha
            spriteRenderer.flipX = false;
        }
        else if(transform.position.x < xPosition)
        {
            //se mueve a la izquierda
            spriteRenderer.flipX = true;
        }
        xPosition = transform.position.x;
    }
}
