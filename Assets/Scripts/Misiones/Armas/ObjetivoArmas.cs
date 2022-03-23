using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ObjetivoArmas : MonoBehaviour
{
   public int numTroncos;
   public TextMeshProUGUI textoMision;
   public GameObject botonMision;

    // Start is called before the first frame update
    void Start()
    {
        numTroncos = GameObject.FindGameObjectsWithTag("tronco").Length;
        textoMision.text = "Encuentra 5 troncos para canjearlos por un arma, \nRestantes: " + numTroncos;
        botonMision.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider col)
    {
        
        if(col.gameObject.tag == "tronco"){
            Destroy(col.transform.parent.gameObject);
            numTroncos--;
            textoMision.text = "Encuentra 5 troncos para canjearlos por un arma, \n Restantes: " + numTroncos;
        }
        if(numTroncos == 0){
             //Aquí colocar el arma
                textoMision.text = "Misión completada";
                botonMision.SetActive(true);
        }
    }
}
