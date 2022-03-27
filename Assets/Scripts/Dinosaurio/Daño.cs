using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Daño : MonoBehaviour
{
    public int        daño;
    public GameObject Player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //Player.GetComponent<ControlarVida>().vidaActual -= daño;
             ControlarVida.restarVida(1);
            
        }
    }
    public void perderVida(int num) {
        Debug.Log("-----------------PERDIO LA VIDA, REINICIAR MISION--------------------------------------");
    } 
   
    

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
