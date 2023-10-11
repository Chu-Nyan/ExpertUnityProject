using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc : Unit, IInteraction
{
    public float gazeDistanse = 5f;
    public Transform gazeTarget;

    public void Interaction()
    {
        throw new System.NotImplementedException();
    }

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
            stateMachine.ChangeState(((NpcStateMachine)stateMachine).idleState);
            ((NpcStateMachine)stateMachine).targetPos = gazeTarget;

        }
    }

}
