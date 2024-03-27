using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class timerGame : MonoBehaviour
{
    public static float tempo, tempoMax;
    public InputField valorTempo;
    public Text tempoTxt;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    public void atribuir()
    {
        tempoMax = float.Parse(valorTempo.text);
        tempoMax *= 60;
    }

    // Update is called once per frame
    void Update()
    {
       // tempo = float.Parse(valorTempo.text);
        tempo = Time.time;
        tempoTxt.text = tempo.ToString("f0");
        if (tempoMax > 0)
        {
            if (tempo >= timerGame.tempoMax)
            {
                SceneManager.LoadScene("tempoEsgotado");
            }
        }
    }
/*
    public void iniciarContagem()
    {
        tempo = int.Parse(valorTempo.text);
        tempo = tempo * 60;
        StartCoroutine("contagemRegressiva");
    }

    IEnumerator contagemRegressiva()
    {
       
        tempoTxt.text = tempo.ToString();
        yield return new WaitForSeconds(1);
        tempo -= 1;

        if (tempo > 0)
        {
            StartCoroutine("contagemRegressiva");
        }
        else
        {
            SceneManager.LoadScene("tempoEsgotado");
        }
    }*/
}
