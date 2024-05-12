using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaPersonaje : MonoBehaviour
{
    public float velocity = 1;
    private Rigidbody2D rb;
    private AudioSource SonidoJump;

    public ControladorEscena controladorEscena;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        SonidoJump = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * velocity;

            SonidoJump.Play();

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        controladorEscena.Perdiste();
    }

}
