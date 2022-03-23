using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirJugador2 : MonoBehaviour
{
    public  Transform                   jugador; //tomar valores de la posicion del jugador
    private UnityEngine.AI.NavMeshAgent enemigo;
    private bool                        dentro = false;
    void Start()
    {
        enemigo = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    void OnTriggerEnter(Collider other)   //cuando el objeto other entre en el tigger pondra la variale dentro
    {                                     // en true
        if (other.tag == "Player")
        {
            dentro = true;
        }
    }

    void OnTriggerExit(Collider other)  // cuando el objeto other salga en el tigger pondra la variable en false
    {
        if (other.tag == "Player")
        {
            dentro = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (!dentro)
        {
            enemigo.destination = jugador.position;  // si el jugador no esta dentro del collider
        }

        if (dentro)
        {
            enemigo.destination = this.transform.position;
        }
    }
}
