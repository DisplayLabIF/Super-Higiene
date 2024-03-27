using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moverBackgroundCeu : MonoBehaviour
{
    private Material matearialAtual;
    public float velocidadex, velocidadey;
    private float escalamovimento;
    // Start is called before the first frame update
    void Start()
    {
        matearialAtual = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        escalamovimento = escalamovimento + 0.01f;
        matearialAtual.SetTextureOffset("_MainTex", new Vector2(escalamovimento * velocidadex, escalamovimento * velocidadey));
    }
}
