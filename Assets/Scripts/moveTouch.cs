using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[RequireComponent(typeof(Rigidbody2D))]

public class moveTouch : MonoBehaviour
{
    Vector3 posicInicial;
    Vector3 posicDestino;
    Vector3 vetorDirecao;
    Rigidbody2D _rigidbody2D;
   // bool estaArrastando;
    float distancia;
   // int escovada = 0;


    [HideInInspector]
    public bool estaConectado;

    [Range(1, 15)]
    public float velocidadeDeMovimento = 10;

    public Transform conector;

    [Range(0.1f, 2.0f)]
    public float distanciaMinimaConector = 0.5f;


    // Start is called before the first frame update
    void Start()
    {
        _rigidbody2D = transform.root.GetComponent<Rigidbody2D>();
        _rigidbody2D.gravityScale = 1;
    }

    private void OnMouseDown()
    {
        posicInicial = transform.root.position - Camera.main.ScreenToWorldPoint(Input.mousePosition);
        _rigidbody2D.gravityScale = 0;
       // estaArrastando = true;
        estaConectado = false;
    }

    private void OnMouseDrag()
    {
        posicDestino = posicInicial + Camera.main.ScreenToWorldPoint(Input.mousePosition);
        vetorDirecao = posicDestino - transform.root.position;
        _rigidbody2D.velocity = vetorDirecao * velocidadeDeMovimento;
    }

    private void OnMouseUp()
    {
        _rigidbody2D.gravityScale = 1;
       // estaArrastando = false;
    }

  /*  private void FixedUpdate()
    {
        if (!estaArrastando && !estaConectado)
        {
            distancia = Vector2.Distance(transform.root.position, conector.position);
            if(distancia < distanciaMinimaConector)
            {
                _rigidbody2D.gravityScale = 0;
                _rigidbody2D.velocity = Vector2.zero;
                transform.root.position = Vector2.MoveTowards (transform.root.position, conector.position, 0.02f);
            }

            if (distancia < 0.10f)
            {
                Debug.Log("Ecovada "+(escovada++));
            }
        }
    }*/

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
