using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody), typeof (BoxCollider))]
public class SeguirJugador : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private FixedJoystick _joystick;
    float x,y,limite = 0;
    float limiteRotacion;
    public float limitMax , limitMin = -60;
     [SerializeField] private float _moveSpeed = 8f;
     public Transform target;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        y -= _joystick.Horizontal * _moveSpeed;
        x += _joystick.Vertical * _moveSpeed;
        limiteRotacion = x;
        limiteRotacion = Mathf.Clamp(limiteRotacion,limitMin,limitMax);

        
         Vector3 targetRotation = new Vector3(limiteRotacion,y);
        
        transform.eulerAngles = targetRotation;
        transform.position = target.position - transform.forward *4f;

    }
}
