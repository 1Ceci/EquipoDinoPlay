using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class ControlarVida : MonoBehaviour
{
    public GameObject mision1,mision2,mision3;
    public GameObject limite1,limite2,limite3;
    public GameObject CanvasM1, CanvasM2,CanvasM3;

    
    public Image barraVida;
    public static float vidaActual=10;
    public float vidaMaxima;
    private int numMision;


    
    void Update()
    {
        numMision= GuardarPartida.numMis;
        if(vidaActual <=0){
            vidaActual=0;
            perderVida(numMision);
        }else if(vidaActual>10){
            vidaActual =10;
        }

        barraVida.fillAmount=vidaActual/vidaMaxima;
    }

    //Metodo que resta vida al jugador se puede implementar desde cualquier script
    public static void restarVida(int vida){
        if(vidaActual > 0){
             vidaActual = vidaActual-vida;
        }
        if(vidaActual<=0){
            //Muere y reiniciar mision
            
        }
        
           
        
    }
    //Metodo que suma vida al Jugador se puede implementar desde cualquier script
    public static void sumarVida(int vida){
        if(vidaActual > 0){
             vidaActual = vidaActual+vida;
        }
        if(vidaActual<=0){
            //Muere y reiniciar mision
            
        }
          
    }
    public void perderVida(int num){
         Debug.Log("-----------------PERDIO LA VIDA, REINICIAR MISION--------------------------------------");
    }
    
    
}
