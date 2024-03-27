using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chuveiro : MonoBehaviour
{
    public GameObject agua;
    public bool ativo = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    public void BtnChamaAnima()
    {
        if (ativo)
        {
            agua.SetActive(false);
            ativo = false;
            GetComponent<AudioSource>().enabled = false;
        }
        else
        {
            agua.SetActive(true);
            agua.SetActive(true);
            ativo = true;
            GetComponent<AudioSource>().enabled = true;
        }

    }

    
}
