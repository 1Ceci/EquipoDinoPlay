using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;
using TMPro;
// AL TOMAR LA TARJETA DEBE DESAPARECER EL MENSAJE Y MOSTRAR INFORMACION EN UN PANEL 
// LA INFORMACION QUE SE MOSTRO EN LA PRIMERA ETIQUETA YA NO DEBE REPETIRSE
// HACER UN ARRAY CON CADENAS DE INFORMACION
// HACER UN ARRAY DE NUMEROS QUE YA SE MOSTRARON OARA QUE NO SE VUELVA A REPETIR 
public class ObjetivoTarjetas : MonoBehaviour
{
    public int numTarjetas;
    public TextMeshProUGUI textoMision;
    public TextMeshProUGUI textoTarjeta;
    public GameObject botonMision;
    public GameObject botonTarjeta;
    string informacion,dirImg;
    public GameObject PanelTextoTarjetas;
    public Image  ImagenTarjeta;
    
  


   


    // Start is called before the first frame update
    void Start()
    {
        GuardarPartida.numMis = 1;
        numTarjetas = GameObject.FindGameObjectsWithTag("Tarjeta").Length;
        textoMision.text = "Obten 10 tarjetas de información " + "\n Restantes: "+numTarjetas;
        botonMision.SetActive(false);
        botonTarjeta.SetActive(false);
        PanelTextoTarjetas.SetActive(false);
        ImagenTarjeta = GameObject.Find("ImagenTarjeta").GetComponent<Image>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider col) // colisionar 
    {
        if(col.gameObject.tag == "Tarjeta"){// si el colisionador es Tarjeta 
            Destroy(col.transform.parent.gameObject);// destruye la tarjeta
            PanelTextoTarjetas.SetActive(true);
            botonTarjeta.SetActive(true);
            informacion = ObtenerInfoTarjetas(numTarjetas);
            textoTarjeta.text = informacion;
            dirImg = ObtenerImagenTarjeta(numTarjetas);
            ImagenTarjeta.sprite = Resources.Load<Sprite>(dirImg);//Carga imagen
            numTarjetas--;
            textoMision.text = "Obten 10 tarjeta de información "  + "\n Restantes: "
                               +  numTarjetas;
            if(numTarjetas <= 0){
                textoMision.text = "Misión completada \n Nueva sección desbloqueada";
                botonMision.SetActive(true);
                GuardarPartida.numMis=1;
            }
            
        } 
        
    }

    string ObtenerInfoTarjetas(int num){
        string[] infoTarjetas ={
            "¿SABÍAS QUÉ...? \n  Tyrannosaurus Rex \n Su nombre significa Reptil Tirano. Vivió durante el periodo Cretácico tardío. Medía de 10 a 14 metros de longitud y pesaba entre cuatro y siete toneladas. Era uno de los carnívoros más feroces. Algunos huesos fósiles de Edmontosaurio y Triceratops muestran marcas de los dientes de este depredador. Las manos de Tiranosaurio eran tan cortas que no le servían para llevarse la comida al hocico."
            ,"¿SABÍAS QUÉ...? \n Diplodocus Longus \n Su nombre significa Viga Doble. Vivió durante el periodo Jurásico tardío. La dieta de este herbívoro pudo haber incluido hojas y frutos de árboles altos y arbustos, así como helechos y equisetos que crecían a nivel del suelo. Medía hasta 27 metros de largo y se calcula que pesaba 20 toneladas."
            ,"¿SABÍAS QUÉ...? \n Allosaurus Fragilis \n Su nombre significa Delicado Reptil Extraño. Este carnívoro vivió en el periodo Jurásico tardío. Medía aproximadamente 12 metros de largo y pesaba hasta dos toneladas. Se alimentaba de pequeños dinosaurios como el Camptosaurio y el Estegosaurio, además de lagartos y mamíferos."
            ,"¿SABÍAS QUÉ...? \n Gallimimus Bullatus \n Su nombre significa Reptil Gallina. Vivió durante el periodo Cretácico tardío. Medía cuatro metros y pesaba un poco más de cuatro toneladas. Era omnívoro y su dieta consistía de pequeños animales, insectos, huevos y plantas que obtenía después de colar el lodo con sus dientes tipo peine. Probablemente corría tan rápido como el avestruz, que alcanza una velocidad de hasta 70 kilómetros por hora."
            ,"¿SABÍAS QUÉ...? \n Velociraptor Mongoliensis \n Su nombre significa Rápido Cazador de Mongolia. Vivió durante el periodo Cretácico tardío. Medía hasta 1.8 metros de longitud y pesaba 15 kilogramos. Era carnívoro. Se cree que su presa favorita era el Protoceratops. Tenía el tamaño de un lobo actual y probablemente cazaba en grupo"
            ,"¿SABÍAS QUÉ...? \n Ornithomimus Velox: \n Su nombre significa Rápido Imitador de Aves. Vivió durante el periodo Cretácico tardío. Esta especie era omnívora. Se alimentaba de plantas, insectos y hasta huevos de otros dinosaurios. Medía tres metros de largo y pesaba hasta 150 kilogramos."
            ,"¿SABÍAS QUÉ...? \n EL Archaeopterix Lithographica. \n Su nombre significa Ala Antigua y vivió en el periodo Jurásico. Era un dinosaurio carnívoro. Su dieta probablemente incluía pequeños reptiles, mamíferos e insectos. Medía aproximadamente 60 centímetros y pesaba 500 gramos. "
            ,"¿SABÍAS QUÉ...? \n Desde la primera presencia de los dinosaurios a su extinción pasaron  unos 174 millones de años, que es mucho más comparado con los Homo sapiens, que han vivido alrededor de 315 000 años."
            ,"¿SABÍAS QUÉ...? \n Se cree que los dinosaurios se extinguieron debido a la caída de un meteorito en territorio mexicano."
            ,"¿SABÍAS QUÉ...? \n La palabra “dinosaurio” viene del griego “deinos” (terrible) y “sauros” (lagartija). "
            };
        string info;
        info= infoTarjetas[num-1];
        return info;
    }

    string ObtenerImagenTarjeta(int num){
        string [] imagenTarjetas = {
              "Misiones/Tarjetas/magenesTarjetas/img10"
            , "Misiones/Tarjetas/ImagenesTarjetas/img9"
            , "Misiones/Tarjetas/ImagenesTarjetas/img8"
            , "Misiones/Tarjetas/ImagenesTarjetas/img7"
            , "Misiones/Tarjetas/ImagenesTarjetas/img6"
            , "Misiones/Tarjetas/ImagenesTarjetas/img5"
            , "Misiones/Tarjetas/ImagenesTarjetas/img4"
            , "Misiones/Tarjetas/ImagenesTarjetas/img3"
            , "Misiones/Tarjetas/ImagenesTarjetas/img2"
            , "Misiones/Tarjetas/ImagenesTarjetas/img1"
        };
        string dirImg = imagenTarjetas[num-1];
        return dirImg;


    }
    

}
