using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogicaGenerador : MonoBehaviour
{
    public float intervaloCreacion = 1f; 
    public GameObject obstaculo;
    public float altura; 
    public float tiempoVida = 10f;

    private float tiempoUltimaCreacion;

    void Start()
    {
        tiempoUltimaCreacion = Time.time;
    }

    void Update()
    {
        if (Time.time - tiempoUltimaCreacion > intervaloCreacion)
        {
            CrearObstaculo();
            tiempoUltimaCreacion = Time.time;
        }
    }

    void CrearObstaculo()
    {
        Vector3 posicionAleatoria = transform.position + new Vector3(
            0,
            Random.Range(-altura, altura) + Random.Range(-0.5f, 0.5f),
            Random.Range(-0.5f, 0.5f)
        );

        GameObject obstaculoNuevo = Instantiate(obstaculo, posicionAleatoria, Quaternion.identity);

        Destroy(obstaculoNuevo, tiempoVida);
    }
}