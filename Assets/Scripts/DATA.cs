using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DATA : MonoBehaviour
{
    public GameObject[] Datas;
    public static int PersonagemAInstanciar;
    
    void Awake()
    {
        Datas = GameObject.FindGameObjectsWithTag("DATA");
        if (Datas.Length >= 2)
        {
            Destroy(Datas[0]);
        }
        DontDestroyOnLoad(transform.gameObject);
    }




}
