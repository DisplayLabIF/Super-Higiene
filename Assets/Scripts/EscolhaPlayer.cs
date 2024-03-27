using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
[RequireComponent(typeof(AudioSource))]
public class EscolhaPlayer : MonoBehaviour
{
    public AudioClip impact;
    AudioSource audioSource;
    public Texture[] Personagem;
    private int SelecaoAtual;


    void Start()
    {
        SelecaoAtual = 0;
        audioSource = GetComponent<AudioSource>();
    }
    void OnGUI()
    {
          
        if (GUI.Button(new Rect(Screen.width / 1.4f, Screen.height / 3, Screen.width / 6.5f, Screen.height / 2.2f), Personagem[1],"Super Limpinha"))
        {
            SelecaoAtual = 0;
            GUI.Button(new Rect(Screen.width / 1.2f - Screen.width / 5, Screen.height / 2 - Screen.height / 2.2f, Screen.width / 3, Screen.height / 1.5f), "");
            audioSource.PlayOneShot(impact, 1);
            DATA.PersonagemAInstanciar = SelecaoAtual;
            AbrirTela();
        }

        if (GUI.Button(new Rect(Screen.width / 7, Screen.height / 3, Screen.width / 2, Screen.height / 2.2f), Personagem[0],"Super limpinho"))
        {
            SelecaoAtual = 1;
            GUI.Button(new Rect(Screen.width / 1.2f - Screen.width / 5, Screen.height / 2 - Screen.height / 2.2f, Screen.width / 3, Screen.height / 1.5f), "");
            audioSource.PlayOneShot(impact, 0.7F);
            DATA.PersonagemAInstanciar = SelecaoAtual;
            AbrirTela();
        }

    }

    void AbrirTela()
    {
        SceneManager.LoadScene("escolherFase");
        return;
    }
}
