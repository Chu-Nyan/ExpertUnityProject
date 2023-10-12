using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcStateMachine : StateMachine
{
    public Npc npc;
    public Transform transform;

    public IState IdleState { get; private set; }
    public IState PatrolState { get; private set; }
    public IState GazeState { get; private set; }

    public Vector3 startPos;
    public Transform targetPos;

    public NpcStateMachine(Npc npc)
    {
        this.npc = npc;
        transform = npc.transform;
        startPos = npc.transform.position;
        targetPos = npc.gazeTarget;

        IdleState = new NpcIdleState(this);
        PatrolState = new NpcPatrolState(this);
        GazeState = new NpcGazeState(this);
        ChangeState(IdleState);
    }
}
