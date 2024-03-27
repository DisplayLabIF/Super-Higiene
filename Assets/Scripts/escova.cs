using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class escova : MonoBehaviour
{
    public static int escovada;
    public GameObject somEscovada;
    // Start is called before the first frame update
    void Start()
    {
        escovada = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (escovada > 0)
        {
            GetComponent<Animator>().SetBool("cortando", true);
        }
        else
        {
            GetComponent<Animator>().SetBool("cortando", false);
        }
    }

   /* void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Colidiu!");
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("Parou de colidir!");
    }*/

    void OnTriggerEnter2D(Collider2D collision)
    {
        escovada++;
        Debug.Log("Colidiu! Escovou "+escovada);
        somEscovada.SetActive(true);

    }

    void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Parou de colidir!");
        somEscovada.SetActive(false);
    }

    
}
