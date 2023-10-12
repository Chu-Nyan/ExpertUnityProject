using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Unit : MonoBehaviour
{
    protected StateMachine stateMachine;

    private void Update()
    {
        stateMachine.Update();
    }

    private void FixedUpdate()
    {
        stateMachine.PhysicsUpdate();

        if (transform.position.y < -10)
        {
            transform.position = Vector3.up*0.5f;
            gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
        }
    }
}
