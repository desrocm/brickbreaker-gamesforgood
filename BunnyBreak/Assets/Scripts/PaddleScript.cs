using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour
{
    public float moveSpeed;
    public GameObject paddle;

    private Rigidbody2D paddleBody;

    // Start is called before the first frame update
    void Start()
    {
        paddleBody = paddle.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void PaddleLeft()
    {
        paddleBody.velocity = new Vector2(-moveSpeed, paddleBody.velocity.y);
    }
    public void PaddleRight()
    {
        paddleBody.velocity = new Vector2(moveSpeed, paddleBody.velocity.y);
    }
    public void PaddleStop()
    {
        paddleBody.velocity = new Vector2(0f, paddleBody.velocity.y);
    }
}
