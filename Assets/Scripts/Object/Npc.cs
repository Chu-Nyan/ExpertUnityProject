using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc : Unit, IInteraction
{
    public float gazeDistanse = 5f;

    public void CheckRange(Vector3 pos)
    {
        //Vector3.Distance
        //transform.position 
    }

    public void Interaction()
    {
        throw new System.NotImplementedException();
    }

    private void Start()
    {
        stateMachine = new NpcStateMachine(this);

    }
}
