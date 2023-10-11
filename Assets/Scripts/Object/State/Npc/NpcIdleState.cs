using System.Collections;
using System.Collections.Generic;
using Unity;
using UnityEngine;

public class NpcIdleState : NpcBaseState
{
    public NpcIdleState(NpcStateMachine stateMachine) : base(stateMachine) { }
    float wait;

    public override void Enter()
    {
        base.Enter();
        wait = 2.0f;
    }

    public override void Update()
    {
        base.Update();
        wait -= Time.deltaTime;
        if (wait<= 0)
            ReadyForPatrol();
    }

    public override void Exit()
    {
        base.Exit();
    }

    private void ReadyForPatrol()
    {
        stateMachine.ChangeState(stateMachine.patrolState);
    }

}
