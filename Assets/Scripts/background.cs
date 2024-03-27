using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class background : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float heigth = Camera.main.orthographicSize * 2f;

        float width = heigth * Screen.width / Screen.height;

        //transform.localScale = new Vector3(width, heigth, 0);

        if (gameObject.name == "background")
        {
            transform.localScale = new Vector3(width, heigth, 0);

        } else
        {
            transform.localScale = new Vector3(width, 2, 0);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
