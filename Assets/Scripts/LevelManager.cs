using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelManager : MonoBehaviour
{
    public static int status=1;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void iniciar()
    {
       
    }

    public void LoadScene(string name)
    {
        Debug.Log("teste" + name);
        SceneManager.LoadScene(name);
      
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    public void onPauseMusic()
    {
        if (GetComponent<AudioListener>().enabled == true)
        {
            GetComponent <AudioListener>().enabled = false;
            status = 0;
            Debug.Log("Audio desligado!");

        } else {
            GetComponent<AudioListener>().enabled = true;
            status = 1;
            Debug.Log("Audio ligado!");
        }

    }
}
