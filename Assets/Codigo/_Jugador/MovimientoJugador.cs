using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    public float velocidad;
    float Xaxis, Yaxis;
    public Rigidbody2D rb;
    private Vector2 movimiento = new Vector2();


    void Update()
    {
        inputs();
    }

    public void FixedUpdate()
    {
        Moverse();
    }

    void inputs()
    {
        Xaxis = Input.GetAxisRaw("Horizontal");
        Yaxis = Input.GetAxisRaw("Vertical");
        movimiento = new Vector2(Xaxis, Yaxis).normalized;
    }

    void Moverse()
    {
        rb.velocity = new Vector2(movimiento.x * velocidad, movimiento.y * velocidad);
    }
}
