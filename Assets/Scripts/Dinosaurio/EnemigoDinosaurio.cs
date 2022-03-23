using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemigoDinosaurio : MonoBehaviour
{
    public int        rutina;
    public float      cronometro;     //tiempo para rutina
    public Animator   anim;
    public Quaternion angulo;
    public float      grado;
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    public void Comportamiento_Enemigo()
    {
        cronometro += 1 * Time.deltaTime;
        if (cronometro >= 4)
        {
            rutina     = Random.Range(0, 2);
            cronometro = 0;
        }

        switch (rutina)
        {
            case 0:
                anim.SetBool("walk", false);
                break;
            case 1:
                grado  = Random.Range(0, 360);
                angulo = Quaternion.Euler(0, grado, 0);
                rutina++;
                break;
            case 2:
                transform.rotation = Quaternion.RotateTowards(transform.rotation, angulo, 0.5f);
                transform.Translate(Vector3.forward * 1 * Time.deltaTime);
                anim.SetBool("walk", true);
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        Comportamiento_Enemigo();
    }
}
