using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameManager : MonoBehaviour
{
    public GameObject painelCompleto;
    public GameObject chuveiro;
    public bool isPaused = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pause()
    {
        if (isPaused)
        {
            painelCompleto.SetActive(false);
            nivelCompleto.texturaLimpeza.SetActive(true);
            chuveiro.SetActive(true);
            isPaused = false;

        }
        else
        {
            painelCompleto.SetActive(true);
            nivelCompleto.texturaLimpeza.SetActive(false);
            chuveiro.SetActive(false);
            isPaused = true;
        }
        
    }

    public void PauseSimples()
    {
        if (isPaused)
        {
            painelCompleto.SetActive(false);
            nivelCompleto.texturaLimpeza.SetActive(true);
            isPaused = false;

        }
        else
        {
            painelCompleto.SetActive(true);
            nivelCompleto.texturaLimpeza.SetActive(false);
            isPaused = true;
        }

    }
}
