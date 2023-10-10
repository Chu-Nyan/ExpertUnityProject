using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private PlayerStateMachine stateMachine;
    public Camera myCamera;
    public PlayerInput InputActions;
    public Rigidbody rigid;
    public Transform mesh;



    public float speed = 200;

    private void Start()
    {
        stateMachine = new PlayerStateMachine(this);
    }

    private void Update()
    {
        stateMachine.Update();
    }

    private void FixedUpdate()
    {
        stateMachine.PhysicsUpdate();
    }
}
