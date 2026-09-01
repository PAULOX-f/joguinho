using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed;
    
    Rigidbody2D rb;
    float xDir, yDir;

    private Vector2 atualPosition;
    private Vector2 targetPosition;
    private bool isMoving = false;
    private float direcao;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        atualPosition = new  Vector2(transform.position.x, transform.position.y);
        
        if (isMoving)
            Move();
    }

    void Move()
    {
        while (atualPosition.x <= targetPosition.x && atualPosition.y <= targetPosition.y && direcao > 0 || atualPosition.x >= targetPosition.x && atualPosition.y >= targetPosition.y && direcao < 0)
        {
            rb.linearVelocityX = xDir * speed;
            rb.linearVelocityY = yDir * speed;
        }
        isMoving = false;
    }

    void OnMove(InputValue value)
    {
        //isMoving = !isMoving;
        print(value.Get<Vector2>());
        xDir = value.Get<Vector2>().x;
        yDir = value.Get<Vector2>().y;
        
        targetPosition = atualPosition + (value.Get<Vector2>() * 1.25f);
        isMoving = true;

        if (xDir != 0)
            direcao = xDir;
        else
            direcao = yDir;
    }
}
