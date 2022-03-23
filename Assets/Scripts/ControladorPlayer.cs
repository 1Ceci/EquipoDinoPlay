using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody), typeof (BoxCollider))]



public class ControladorPlayer : MonoBehaviour
{
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private FixedJoystick _joystick;
    [SerializeField] private Animator _animator;

    [SerializeField] private float _moveSpeed;
    float x,y,z;
    private void FixedUpdate()
    {

        x= _joystick.Horizontal * _moveSpeed;
        y =  _rigidbody.velocity.y;
        z = _joystick.Vertical * _moveSpeed;
        _rigidbody.velocity = new Vector3(x, y, z);
        _animator.SetFloat("VelY", y);
        _animator.SetFloat("VelX", x);
        // if (_joystick.Horizontal != 0 || _joystick.Vertical != 0)
        // {
        //     transform.rotation = Quaternion.LookRotation(_rigidbody.velocity);
        //     _animator.SetFloat("VelY", y);
        // }
        // else
            
    }
}
