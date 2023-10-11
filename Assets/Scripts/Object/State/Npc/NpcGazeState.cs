using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcGazeState : NpcBaseState
{
    public NpcGazeState(NpcStateMachine stateMachine) : base(stateMachine) { }

    public override void Enter()
    {
        base.Enter();
    }

    public override void Update()
    {
        base.Update();

        Vector3 look = stateMachine.targetPos.position - stateMachine.npc.transform.position;
        look.y = 0;
        look.Normalize();
        var lookDir = Quaternion.LookRotation(look);
        stateMachine.npc.transform.rotation = Quaternion.Lerp(stateMachine.transform.rotation, lookDir, 0.1f);
    }


    public override void Exit()
    {
        base.Exit();
    }

}
