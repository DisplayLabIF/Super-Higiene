using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InstanciadorPlayer : MonoBehaviour
{
    public Vector3 posicaoParaInstanciar;
    public float rotacaoEmX, rotacaoEmY, rotacaoEmZ;
    public GameObject[] players;
    public float contadorTempos;
    public Text campoTempoTxts;

    // Start is called before the first frame update
    void Start()
    {
        contadorTempos = timerGame.tempo;
        Instantiate(players[DATA.PersonagemAInstanciar], posicaoParaInstanciar, Quaternion.Euler(rotacaoEmX, rotacaoEmY, rotacaoEmZ));
        
    }

    

    // Update is called once per frame
    void Update()
    {
        contadorTempos = Time.time;
        campoTempoTxts.text = contadorTempos.ToString("f0");
        if(timerGame.tempoMax > 0)
        {
            if(contadorTempos >= timerGame.tempoMax)
            {
                SceneManager.LoadScene("tempoEsgotado");
            }
        }
    }
}
