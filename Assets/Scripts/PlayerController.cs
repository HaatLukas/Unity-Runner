using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    public bool jumped; // Czy kto� skoczy�?
    public bool doublejumped; // Czy kto� skoczy� dwukrotnie?

    public float jumpForce; // Si�a skoku
    public float liftingForce; // Si�a unoszenia

    public LayerMask whatIsGround; // Co uznajemy za ziemi�?

    private Rigidbody2D rb; // Nasze Rigidbody (Fizyka)
    private BoxCollider2D collision; // Nasze pude�ko z kolizj�
    private float timestamp; // Piecz�tka czasowa

    private InputMaster Input; // Nasze sterowanie


    private void Awake()
    {
        Input = new InputMaster();
    }

    private void Jump()
    {
        if (jumped == false)
        {
            rb.velocity = (new Vector2(0f, jumpForce));
            jumped = true;
        }
        else if ( doublejumped == false )
        {
            rb.velocity = (new Vector2(0f, jumpForce));
            doublejumped = true;
        }

        if (rb.velocity.y < 0)
        {
            rb.AddForce(new Vector2(0f, liftingForce * Time.deltaTime));
        }
    }


    void Start()
    {
        // Na starcie wgrywamy rb i kolizje od elementu do kt�rego jeste�my
        // przyczepieni
        rb = GetComponent<Rigidbody2D>();
        collision = GetComponent<BoxCollider2D>();
    }
    void Update()
    {
        
    }

    private bool IsGrounded()
    {
        RaycastHit2D hit = Physics2D.BoxCast(collision.bounds.center,
            collision.bounds.size, 0, Vector2.down, 0.1f, whatIsGround);
        return hit.collider != null;
    }

    




}
