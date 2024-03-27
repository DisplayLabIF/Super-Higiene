using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMoviment : MonoBehaviour
{
   // public float speed = 2f;
    public float jumpForce = 5f;
    private Rigidbody2D myRB;
    private bool colisao;
    // Start is called before the first frame update
    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Stationary)
        {
            myRB.velocity = new Vector2(2f, 0f);
        }

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Moved && colisao == true)
        {
            myRB.velocity = new Vector2(0f, jumpForce);
        }
    }

     void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("plataforma"))
        {
            colisao = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        colisao = false;
    }


}
