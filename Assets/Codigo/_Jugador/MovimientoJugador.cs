using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoJugador : MonoBehaviour
{
    public float velocidad = 5f;
    float Xaxis, Yaxis;
    public Rigidbody2D rb;
    private Vector2 movimiento = new Vector2();
    private Animator animator;
    public bool animacion;
    public bool atack;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

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
        disparo();


        if (Xaxis != 0 || Yaxis != 0)
        {
            animator.SetBool("Move", true);
        }
        else
        {
            rb.velocity = Vector2.zero;
            animator.SetBool("Move", false);
        }

        if (Xaxis > 0)
        {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
        if (Xaxis < 0)
        {
            transform.localScale = new Vector3(-1f, 1f, 1f);
        }
    }

    void Moverse()
    {
        rb.velocity = new Vector2(movimiento.x * velocidad, movimiento.y * velocidad);
    }

    void disparo()
    {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            atack = true;
            animator.SetBool("Shoot", true);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            atack = false;
            animator.SetBool("Shoot", false);
        }
    }
}
