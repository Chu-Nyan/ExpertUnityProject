using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc : Unit
{
    public float gazeDistanse = 5f;
    public Transform gazeTarget;


    private void Start()
    {
        stateMachine = new NpcStateMachine(this);
    }


    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gazeTarget = other.gameObject.transform;
            ((NpcStateMachine)stateMachine).targetPos = gazeTarget;
        }
    }


    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gazeTarget = null;
            stateMachine.ChangeState(((NpcStateMachine)stateMachine).IdleState);
            ((NpcStateMachine)stateMachine).targetPos = gazeTarget;
        }
    }

}
