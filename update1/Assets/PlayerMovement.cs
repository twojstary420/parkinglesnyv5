using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    private float Move;

    public float jump;

    public bool isJumping;

    private Rigidbody2D rb;

    public BombManager bm;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move = Input.GetAxis("Horizontal");

        rb.velocity = new Vector2(speed * Move, rb.velocity.y);

        if(Input.GetButtonDown("Jump") && isJumping == false)
        {
            rb.AddForce(new Vector2(rb.velocity.x, jump));
        }

        if (Move > 0f)
        {
            transform.localScale = new Vector2(0.7934729f, 0.8081876f);
        }
        else if (Move < 0f)
        {
            transform.localScale = new Vector2(-0.7934729f, 0.8081876f);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isJumping = false;
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground")) 
        {
            isJumping = true;
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Bomb"))
        {
            Destroy(other.gameObject);
            bm.bombCount++;
        }
    }
}
