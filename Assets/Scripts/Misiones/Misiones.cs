using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Misiones : MonoBehaviour
{

    public static int MisionActual=0;
    public static Misiones misiones;
    public static bool[] ArrayMision;
    public GameObject Mision1;
    public GameObject Mision2;
    public GameObject Mision3;
    
      void Start()
    {
        ArrayMision = new bool[5];
        Misiones.ArrayMision[MisionActual]=false;
        ControlMisiones(MisionActual);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ControlMisiones(int MisionActual){
        // inicar misiones
    if(MisionActual==0){
    
    Mision1.SetActive(true);
    Mision2.SetActive(false);
    Mision3.SetActive(false);
    }
    if (MisionActual ==1){
     Destroy(Mision1);
        Mision2.SetActive(true);
        Mision3.SetActive(false);
    }
   if (MisionActual ==2){
        Mision1.SetActive(false);
        Mision2.SetActive(false);
        Mision3.SetActive(true);
    }
   
    }

} 
