using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ObjetivoAlimento : MonoBehaviour
{
    public int numAlimento,hongosMasV,hongosMenosV,alimento ;
    public TextMeshProUGUI textoMision;
    public GameObject botonMision;
    void Start()
    {
        alimento = GameObject.FindGameObjectsWithTag("Alimento").Length;
        hongosMasV = GameObject.FindGameObjectsWithTag("AlimentoP").Length;
        hongosMenosV = GameObject.FindGameObjectsWithTag("AlimentoN").Length;
        numAlimento = hongosMasV + alimento;
        textoMision.text = "Recolecta Alimento agua y hongos(azules) te darán vida," + "\n Restantes: "+ numAlimento;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        
        if(col.gameObject.tag == "Alimento" || col.gameObject.tag == "AlimentoP" || col.gameObject.tag == "AlimentoN"){
            
            if(col.gameObject.tag == "Alimento" || col.gameObject.tag == "AlimentoP" ){
            numAlimento--;
            textoMision.text = "Recolecta Alimento agua y hongos, \n Restantes: " + numAlimento;
            ControlarVida.sumarVida(1);
            }else 
                if(col.gameObject.tag == "AlimentoN"){
                    ControlarVida.restarVida(2);
                }
            Destroy(col.transform.parent.gameObject);
        }
        if(numAlimento == 0){
             //Aquí colocar el arma
                
                textoMision.text = "Misión completada";
                botonMision.SetActive(true);
                GuardarPartida.numMis=2;
        }
    }
}
