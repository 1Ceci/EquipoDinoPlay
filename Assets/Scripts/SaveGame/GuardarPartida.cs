 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GuardarPartida : MonoBehaviour
{



    //INT (UI)
    [Header("Save Player")]
    public Transform player;
    private Vector3 positionPlayer;
    private Vector3 positionMision1;
    
    public static int numMis= 0;
     [Header("Misiones")]
    public GameObject mision1;
    public GameObject mision2;
    public GameObject mision3;
    public GameObject limite1;
    public GameObject limite2;
    public GameObject limite3;

    public GameObject CanvasM1;
    public GameObject CanvasM2;
    public GameObject CanvasM3;
    
    public static Vector3 positionPlayerStatic;
     public static Transform playerStatic;
    
   
    // GuardarPartida en que mision esta:
    // podria crear una variable global que indique el numero de la mision
    // Al cargar destruir los elementos que no pertenecen a esa mision.
    // objeto en misiones 
    // el canvas
    // limites
    // "Si se quedo a mitad de una mision poner un aviso, si sales perderas tu avance de esta mision."

    //Guardar la posicion del objeto.

    //Guardar misionActual = mision 






    // Use this for initialization
    private void Start()
    {
        //Guardar posicion de jugador
        positionPlayer = SaveSystem.GetVector3("positionPlayer");
        player.transform.position=positionPlayer; 
        //Guardar numero de mision
        numMis = SaveSystem.GetInt("mision");
        obtenerMision(numMis);
    }

    public static void recargarMision(){
        //implementar lo del Start
    }
    

    public void reiniciarPartida(){
        Vector3 vector3 = new Vector3(53,3,78);
        positionPlayer=vector3;
        SaveSystem.SetVector3("positionPlayer", positionPlayer);
        numMis=0;
        SaveSystem.SetInt("mision", numMis);
        Debug.Log("-------------------------------------------------------");
        Debug.Log(numMis);
        Debug.Log(positionPlayer);
        SceneManager.LoadScene("Nivel1");
          
    }
    public void obtenerMision(int num){
        

        if (num == 1){
            mision1.SetActive(false);
            limite1.SetActive(false);
            CanvasM1.SetActive(false);
            CanvasM2.SetActive(true);
        }else if(num == 2){
            mision1.SetActive(false);
            limite1.SetActive(false);
            CanvasM1.SetActive(false);
            mision2.SetActive(false);
            limite2.SetActive(false);
            CanvasM2.SetActive(false);
        }else if(num ==3){
            mision1.SetActive(false);
            limite1.SetActive(false);
            CanvasM1.SetActive(false);
            mision2.SetActive(false);
            limite2.SetActive(false);
            CanvasM2.SetActive(false);
            // mision3.SetActive(false);
            // limite3.SetActive(false);
            // CanvasM3.SetActive(false);

        }

    }

    public void continuarPartida(){
        positionPlayer = SaveSystem.GetVector3("positionPlayer");
        SaveSystem.SetVector3("positionPlayer", positionPlayer);

        player.transform.position=positionPlayer;
        numMis = SaveSystem.GetInt("mision");


    }

    //Button Save INT
    public void SaveCube()
    {
        positionPlayer = player.transform.position;
        Debug.Log("-------------------------------------------------------");
        Debug.Log(player.transform.position);
        SaveSystem.SetVector3("positionPlayer", positionPlayer);
        SaveSystem.SetInt("mision", numMis);
    }

    //Save "NEXT"
    private void OnApplicationQuit()
    {
        
        SaveSystem.SetVector3("positionPlayer", positionPlayer);
        SaveSystem.SetInt("mision", numMis);
       
        
    }

    //Save "NEXT"
    private void OnApplicationPause(bool pause)
    {
        if (pause)
        {
            
            SaveSystem.SetVector3("positionPlayer", positionPlayer);
            SaveSystem.SetInt("mision", numMis);
            
            
        }
    }

}

