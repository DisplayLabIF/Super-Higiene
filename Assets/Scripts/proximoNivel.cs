using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class proximoNivel : MonoBehaviour
{
    public GameObject estrela1;
    public GameObject estrela2;
    public GameObject estrela3;
    public GameObject nenhuma;
    public GameObject estrela3Libras;
    public bool oneStar = false;
    public bool twoStar = false;
    public bool treeStar = false;
    public bool zeroStar = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (barraLimpeza.limpezaPersonagem >= barraLimpeza.total)
        {
            estrela3.SetActive(true);
            estrela3Libras.SetActive(true);
            treeStar = true;
            estrela2.SetActive(false);
            twoStar = false;
            estrela1.SetActive(false);
            oneStar = false;
            nenhuma.SetActive(false);
            zeroStar = false;
            nivelCompleto.texturaLimpeza.SetActive(false);

        }
        else if (barraLimpeza.limpezaPersonagem < barraLimpeza.total && barraLimpeza.limpezaPersonagem >= barraLimpeza.media)
        {
            estrela2.SetActive(true);
            estrela3Libras.SetActive(false);
            twoStar = true;
            estrela1.SetActive(false);
            oneStar = false;
            estrela3.SetActive(false);
            treeStar = false;
            nenhuma.SetActive(false);
            zeroStar = false;
            nivelCompleto.texturaLimpeza.SetActive(false);

        }
        else if (barraLimpeza.limpezaPersonagem < barraLimpeza.media && barraLimpeza.limpezaPersonagem >= barraLimpeza.baixa)
        {
            estrela1.SetActive(true);
            estrela3Libras.SetActive(false);
            oneStar = true;
            estrela2.SetActive(false);
            twoStar = false;
            estrela3.SetActive(false);
            treeStar = false;
            nenhuma.SetActive(false);
            zeroStar = false;
            nivelCompleto.texturaLimpeza.SetActive(false);

        } else if (barraLimpeza.limpezaPersonagem < barraLimpeza.baixa)
        {
            nenhuma.SetActive(true);
            estrela3Libras.SetActive(false);
            zeroStar = true;
            estrela1.SetActive(false);
            oneStar = false;
            estrela2.SetActive(false);
            twoStar = false;
            estrela3.SetActive(false);
            treeStar = false;
            nivelCompleto.texturaLimpeza.SetActive(false);
        }
    }

    public void proximo()
    {
       
    }
}
