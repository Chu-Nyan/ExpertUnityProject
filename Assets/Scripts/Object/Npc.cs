using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc : Unit
{
    private void Start()
    {
        stateMachine = new NpcStateMachine(this);
    }
}
