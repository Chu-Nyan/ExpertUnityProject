using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcStateMachine : StateMachine
{
    public Npc npc;
    public Transform transform;
    public Rigidbody rigid;

    public IState idleState;
    public IState patrolState;
    public IState gazeState;

    public Vector3 startPos;

    public NpcStateMachine(Npc npc)
    {
        this.npc = npc;
        rigid = npc.rigid;
        transform = npc.transform;
        startPos = npc.transform.position;

        idleState = new NpcIdleState(this);
        patrolState = new NpcPatrolState(this);
        gazeState = new NpcGazeState(this);
        ChangeState(idleState);
    }

}
