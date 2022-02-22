using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Personaje : MonoBehaviour
{
    // Start is called before the first frame update
    private  float velocidadJugador = 10f;
    private  float gravedad = -.05f;

    private  float salto = 10f; 
    private static Vector2 posicionJugador;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    // Update is called once per frame
    void Update()
    {
        input();
    }


    public void input()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float velocidadVertical = rb.velocity.y + gravedad;

        if(Input.GetKeyDown(KeyCode.W)){
            velocidadVertical += -rb.velocity.y + salto;
        }

        
        rb.velocity = new Vector2(velocidadJugador * horizontal, velocidadVertical);
    }

}
