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
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        Move();
    }

    void Move()
    {
        rb.linearVelocityX = xDir + 15;
        rb.linearVelocityY = yDir + 15;
    }

    void OnMove(InputValue value)
    {
        print(value.Get<Vector2>());
        xDir = value.Get<Vector2>().x;
        yDir = value.Get<Vector2>().y;
    }
}
