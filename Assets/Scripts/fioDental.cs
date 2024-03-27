using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fioDental : MonoBehaviour
{
    public GameObject fio, botao;

    // Start is called before the first frame update
    void Start()
    {
        botao.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ativarFio()
    {
        fio.SetActive(true);
        botao.SetActive(false);
    }
}
