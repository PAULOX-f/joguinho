using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    Rigidbody2D rb;
    float xDir, yDir;


    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        Move();
        
    }

    void Move()
    {
            rb.linearVelocityX = xDir * 15;
            rb.linearVelocityY = yDir * 15;
        
    }

    void OnMove(InputValue value)
    {
        print(value.Get<Vector2>());
        xDir = value.Get<Vector2>().x;
        yDir = value.Get<Vector2>().y;
    }
}
