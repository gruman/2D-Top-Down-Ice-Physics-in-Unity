using UnityEngine;

public class PlayerController : MonoBehaviour
{

    private Rigidbody2D player;
    public float speed = 3.0f;

    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Vector2 direction = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical")) * speed;
        player.AddForce(direction, ForceMode2D.Force);
    }
}
