using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BallForce : MonoBehaviour
{
    public Rigidbody2D rb; 
    public float ballForce;
    bool gameStarted = false;
    public GameObject startbutton;
    public Transform paddle;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void ReleaseBall()
    {
        transform.SetParent(null);
        rb.isKinematic = false;
        rb.AddForce(new Vector2(ballForce, ballForce));
        gameStarted = true;
        Destroy(startbutton);
    }
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "ground")
        {
            SceneManager.LoadScene(0);
            
        }
    }
}
