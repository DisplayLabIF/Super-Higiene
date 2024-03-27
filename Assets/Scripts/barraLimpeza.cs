using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barraLimpeza : MonoBehaviour
{
    public static int limpezaPersonagem;
    public Texture agua;
    public Texture frame;
    public int totalLimpeza;
    public static int total;
    public int mediaLimpeza;
    public int baixaLimpeza;
    public static int media;
    public static int baixa;
    public GameObject botao;
    public GameObject espuma;
    public int ana;

    // Start is called before the first frame update
    void Start()
    {
        limpezaPersonagem = 0;
    }

    // Update is called once per frame
    void Update()
    {
        total = totalLimpeza;
        media = mediaLimpeza;
        baixa = baixaLimpeza;
        limpezaPersonagem = escova.escovada;
        if (limpezaPersonagem >= totalLimpeza)
        {
            limpezaPersonagem = totalLimpeza;
           
        } else if (limpezaPersonagem <= 0)
        {
            limpezaPersonagem = 0;
           
        }

        if (limpezaPersonagem > (baixa/2 ))
        {
            botao.SetActive(true);
            
        } 
        if (limpezaPersonagem >= 1)
        {
            espuma.SetActive(true);
        }

       

    }

    private void OnGUI()
    {
        GUI.DrawTexture(new Rect(Screen.width / 40, Screen.height / 1.3f, Screen.width / 4, Screen.height / 10), frame);
        GUI.DrawTexture(new Rect (Screen.width / 25, Screen.height / 1.255f, Screen.width / 4.60f / totalLimpeza * limpezaPersonagem, Screen.height / 25), agua);
        
    }
}
