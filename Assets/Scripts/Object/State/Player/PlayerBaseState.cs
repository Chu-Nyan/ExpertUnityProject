using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBaseState : IState
{
    protected PlayerStateMachine stateMachine;

    public PlayerBaseState(PlayerStateMachine stateMachine) { this.stateMachine = stateMachine; }


    public virtual void Enter() { }
    public virtual void PhysicsUpdate() { }
    public virtual void Update() { }
    public virtual void Exit() { }


    protected virtual void AddKeyMap()
    {
        stateMachine.player.InputActions.KeyBoardActions.Move.started += OnMoveKeyInput;
        stateMachine.player.InputActions.KeyBoardActions.Move.canceled += OnMoveKeyInput;
    }


    protected virtual void DelKeyMap()
    {
        stateMachine.player.InputActions.KeyBoardActions.Move.started -= OnMoveKeyInput;
        stateMachine.player.InputActions.KeyBoardActions.Move.canceled -= OnMoveKeyInput;
    }



    protected virtual void OnMoveKeyInput(InputAction.CallbackContext context)
    {
        stateMachine.Movement = stateMachine.player.InputActions.KeyBoardActions.Move.ReadValue<Vector2>();
    }


    protected virtual void Movement()
    {

        stateMachine.Movement = stateMachine.player.InputActions.KeyBoardActions.Move.ReadValue<Vector2>();
        Vector3 pos = GetDir().normalized;

        stateMachine.player.rigid.AddForce(pos * stateMachine.player.speed * Time.fixedDeltaTime);
    }


    private Vector3 GetDir()
    {
        Vector3 forword = stateMachine.player.mainCamera.transform.forward;
        Vector3 right = stateMachine.player.mainCamera.transform.right;
        forword.y = 0;
        right.y = 0;
        forword.Normalize();
        right.Normalize();

        return forword * stateMachine.Movement.y + right * stateMachine.Movement.x;
    }
}
