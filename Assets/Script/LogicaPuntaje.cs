using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class LogicaPuntaje : MonoBehaviour
{
    public static int puntaje = 0;
    private int puntajeAnterior = 0;
    public AudioSource audioSource; 
    public AudioClip audioClip;

    // Intente primero que al momento que se destruyera el objeto se escuchara el sonido pero esta fue la solucion que llegue despues de hacerme bolas un rato.

    void Start()
    {
        puntaje = 0;
        if (audioSource == null)
        {
            audioSource = GetComponent<AudioSource>();
        }
        audioSource.clip = audioClip; 
    }

    void Update()
    {
        if (puntaje != puntajeAnterior)
        {
            puntajeAnterior = puntaje;
            ReproducirAudio();
        }

        GetComponent<TextMeshProUGUI>().text = puntaje.ToString();
    }

    void ReproducirAudio()
    {
        if (audioSource != null && audioSource.clip != null)
        {
            audioSource.Play();
        }
    }
}