using UnityEngine;
public class MoveState : State
{
    public override void Enter()
    {
        base.Enter();
        Debug.Log("Enter the Move state");
    }

    public override void Exit()
    {
        base.Exit();
        Debug.Log("Exit the Move state");
    }

    public override void Update()
    {
        base.Update();
        Debug.Log("Moving ....... ");
    }
}
