using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NpcPatrolState : NpcBaseState
{
    public NpcPatrolState(NpcStateMachine stateMachine) : base(stateMachine) { }
    Vector3 nextPos;

    public override void Enter()
    {
        base.Enter();
        float x = Random.Range(-5, 5f);
        float z = Random.Range(-5, 5f);
        nextPos = new Vector3(stateMachine.startPos.x - x, 0, stateMachine.startPos.z - z);
        Vector3 Dir = nextPos - stateMachine.transform.position;
        stateMachine.transform.rotation = Quaternion.LookRotation(Dir.normalized);
    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void PhysicsUpdate()
    {
        base .PhysicsUpdate();
        stateMachine.npc.transform.position = Vector3.Lerp(stateMachine.transform.position, nextPos, 0.025f);
        if ((stateMachine.npc.transform.position - nextPos).magnitude <= 0.01f)
        {
            stateMachine.ChangeState(stateMachine.idleState);
        }

    }
}
