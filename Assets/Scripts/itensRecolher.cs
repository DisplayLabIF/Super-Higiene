 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itensRecolher : MonoBehaviour
{
    public GameObject[] objetos;
    public float intervaloSpawnn;
    public Transform spawnPosition;


    void Start()
    {
        StartCoroutine("Spawn");
        
    }

    IEnumerator Spawn()
    {
        int idObjeto = Random.Range(0, objetos.Length);
        Instantiate(objetos[idObjeto], spawnPosition.position, spawnPosition.rotation);
        yield return new WaitForSeconds(intervaloSpawnn);
        StartCoroutine("Spawn");
    }


}
