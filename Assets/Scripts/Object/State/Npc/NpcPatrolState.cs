using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Rendering.LookDev;
using UnityEngine;

public class NpcPatrolState : NpcBaseState
{
    public NpcPatrolState(NpcStateMachine stateMachine) : base(stateMachine) { }
    Vector3 nextPos;
    Vector3 dir;
    Quaternion dirRotate;
    readonly float rotateTimeMax = 1.5f;
    float rotateTime;

    public override void Enter()
    {
        base.Enter();
        float x = Random.Range(-5, 5f);
        float z = Random.Range(-5, 5f);
        nextPos = new Vector3(stateMachine.startPos.x - x, 0, stateMachine.startPos.z - z);
        dir = nextPos - stateMachine.transform.position;
        dir.Normalize();
        dirRotate = Quaternion.LookRotation(dir);

        rotateTime = rotateTimeMax;

    }

    public override void Exit()
    {
        base.Exit();
    }

    public override void PhysicsUpdate()
    {
        base .PhysicsUpdate();
        if (rotateTime > 0f)
        {
            stateMachine.npc.transform.rotation = Quaternion.Lerp(stateMachine.transform.rotation, dirRotate, 0.1f);
            rotateTime -= Time.fixedDeltaTime;
            return;
        }



        stateMachine.npc.transform.position = Vector3.Lerp(stateMachine.transform.position, nextPos, 0.025f);
        if ((stateMachine.npc.transform.position - nextPos).magnitude <= 0.01f)
        {
            stateMachine.ChangeState(stateMachine.idleState);
        }

    }
}
