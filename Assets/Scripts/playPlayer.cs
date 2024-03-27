using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.SceneManagement;

public class playPlayer : MonoBehaviour
{
    public float jumpForce = 5f;
    private Rigidbody2D myRB;
    private bool canJump;
    public float forwardForce = 0f;
    private int presentes;
    public int tempoFase;
    public Text presentesTxt; //tempoTxt; //
    public GameObject som;
    private int qtdPulo = 0, aux = 0;
    public float contadorTempo;
    public Text campoTempoTxt;

    void Start()
    {
        myRB = GetComponent<Rigidbody2D>();
        // StartCoroutine("contagemRegressiva");
        contadorTempo = timerGame.tempo;

    }

    // Update is called once per frame
    void Update()
    {
        contadorTempo = Time.time;
        campoTempoTxt.text = contadorTempo.ToString("f0");

        if (qtdPulo >= 2 || aux == 1)
        {
            GetComponent<Animator>().SetBool("sujo", true);
            aux = 1;
        } else
        {
            GetComponent<Animator>().SetBool("sujo", false);
            aux = 0;
        }

        if(Input.touchCount > 0)
        {
            if (canJump)
            {
                canJump = false;
                qtdPulo++;

                if (transform.position.x < 0)
                {
                    forwardForce = 1f;

                }
                else
                {
                    forwardForce = 0f;
                }
                myRB.velocity = new Vector2(forwardForce, jumpForce);
            }
        }
        
    }

  /*  public void Jump()
    {
        if (canJump)
        {
            canJump = false;
            qtdPulo++;

            if (transform.position.x < 0)
            {
                forwardForce = 1f;
                
            } else
            {
                forwardForce = 0f;
            }
            myRB.velocity = new Vector2(forwardForce, jumpForce); 
        }
        
    }*/

    void OnCollisionEnter2D (Collision2D other)
    {
        canJump = true;
    }
/*
    IEnumerator contagemRegressiva()
    {
        tempoTxt.text = tempoFase.ToString();
        yield return new WaitForSeconds(1);

        tempoFase -= 1;

        if(tempoFase > 0)
        {
            StartCoroutine("contagemRegressiva");
        } else
        {
            SceneManager.LoadScene("gameOver");
        }
    }*/
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Coin")
        {
            som.GetComponent<AudioSource>().Play();
            presentes += 1;
            presentesTxt.text = presentes.ToString();
            Destroy(collision.gameObject);

        }

        if (collision.tag == "Lama")
        {
            GetComponent<Animator>().SetBool("sujo", true);
            aux = 1;
        }

        if (collision.tag == "Coin" && aux == 1)
        {
            GetComponent<Animator>().SetBool("sujo", false);
            aux = 0;
            qtdPulo = 0;
        }

        
    
        
    }


  
}
