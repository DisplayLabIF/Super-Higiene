using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monstrinhos : MonoBehaviour
{
    public GameObject monstro;
    public int cont;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        cont++;
       
        if (cont >= 3)
        {
            monstro.SetActive(false);
            Debug.Log("Mosntro morreu ");
        }
        
    }

    void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Parou de colidir!");
        
    }
}
