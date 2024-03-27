using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musica : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (LevelManager.status == 0)
        {
            GetComponent<AudioListener>().enabled = false;
        } else
        {
            GetComponent<AudioListener>().enabled = true;
        }
    }
}
