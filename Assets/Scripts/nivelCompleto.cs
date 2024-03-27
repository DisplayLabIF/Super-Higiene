using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nivelCompleto : MonoBehaviour
{
    public GameObject painelNivelCompleto;
    public GameObject textura;
    public static GameObject texturaLimpeza;
    public bool isPaused = false;
    // Start is called before the first frame update
    void Start()
    {
        texturaLimpeza = textura;
        texturaLimpeza.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        if (barraLimpeza.limpezaPersonagem >= barraLimpeza.total)
        {
            painelNivelCompleto.SetActive(true);
            isPaused = true;
           

        }
        else if (barraLimpeza.limpezaPersonagem <= 0)
        {
            painelNivelCompleto.SetActive(false);
            isPaused = false;
        }
    }
}
