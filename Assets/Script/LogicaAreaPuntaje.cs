using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class LogicaAreaPuntaje : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        LogicaPuntaje.puntaje++;
        Destroy(gameObject);
    }
}
