using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TestSaveGame : MonoBehaviour
{
    //INT (UI)
    [Header("Save int")]
    public Transform player;
    // public Text countIntText;
    // public InputField inputIntField;
    // public int cubeIntCount = 0;
    // [Space(10)]

    // //Next variables
    // [Header("Save next")]
    // public float floatCount;
    // public Vector2 vect2;
    private Vector3 vect3;
    // public Color color;
    // public string stringSave;
    // public bool saveBool;
    
   
    



    // Use this for initialization
    private void Start()
    {

         
      
        //Load Save int
        //cubeIntCount = SaveSystem.GetInt("cubeCount"); //Obtiene el valor que tiene el cubo
        // countIntText.text = cubeIntCount.ToString();

        //Load save Next
        // floatCount = SaveSystem.GetFloat("float");
        // saveBool = SaveSystem.GetBool("bool");
        // vect2 = SaveSystem.GetVector2("vect2");
        vect3 = SaveSystem.GetVector3("vect3");
        // player.transform.position=vect3;
        // color = SaveSystem.GetColor("color");
        // stringSave = SaveSystem.GetString("string");



    }


    //Button Save INT
    public void SaveCube()
    {
        vect3 = player.transform.position;
        Debug.Log("-------------------------------------------------------");
        Debug.Log(player.transform.position);
        //countIntText.text = inputIntField.text;
        //cubeIntCount = int.Parse(inputIntField.text);

        //Save "cubeCount"
        //SaveSystem.SetInt("cubeCount", cubeIntCount);
        SaveSystem.SetVector3("vect3", vect3);

    }

    //Save "NEXT"
    private void OnApplicationQuit()
    {
        
        // SaveSystem.SetFloat("float", floatCount);
        // SaveSystem.SetBool("bool", saveBool);
        // SaveSystem.SetVector2("vect2", vect2);
        SaveSystem.SetVector3("vect3", vect3);
       
        // SaveSystem.SetColor("color", color);
        // SaveSystem.SetString("string", stringSave);
    }

    //Save "NEXT"
    // private void OnApplicationPause(bool pause)
    // {
    //     if (pause)
    //     {
    //         // SaveSystem.SetFloat("float", floatCount);
    //         // SaveSystem.SetBool("bool", saveBool);
    //         // SaveSystem.SetVector2("vect2", vect2);
    //         SaveSystem.SetVector3("vect3", vect3);
    //         // SaveSystem.SetColor("color", color);
    //         // SaveSystem.SetString("string", stringSave);
    //     }
    // }

}
