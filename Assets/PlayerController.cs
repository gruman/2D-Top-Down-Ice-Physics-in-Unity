using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody2D player;

    public float speed = 6.0f;
    private bool isIce;

    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (isIce)
        {
            Vector2 direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * speed;
            player.AddForce(direction, ForceMode2D.Force);
        }
        else
        {
            player.velocity = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * speed;
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ice")
        {
            isIce = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Ice")
        {
            isIce = false;
        }
    }
}
