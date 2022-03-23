using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemigo : MonoBehaviour
{
    public  float   movementSpeed = 1f;
    private Vector3 targetPosition;
    private Vector3 towardsTarget;

    private float wanderRadius = 5f;

    void RecalculateTargetPosition()
    {
        targetPosition   = transform.position + Random.insideUnitSphere * wanderRadius;
        targetPosition.y = 0;
    }
    void Start()
    {
       RecalculateTargetPosition(); 
    }

    // Update is called once per frame
    void Update()
    {
        towardsTarget = targetPosition - transform.position;
        if (towardsTarget.magnitude < 0.25f)
        {
            RecalculateTargetPosition();
            transform.position += towardsTarget.normalized * movementSpeed * Time.deltaTime;
            
            Debug.DrawLine(transform.position, targetPosition);
        }
    }
}
