using UnityEngine;

public class Player : MonoBehaviour
{
    private StateMachine _sm;

    private AttackState _attackState;
    private IdileState _idileState;
    private MoveState _moveState;

    private void Start()
    {
        _sm = new StateMachine();

        _attackState = new AttackState(this);
        _idileState = new IdileState(this);
        _moveState = new MoveState();

        _sm.Initialize(new IdileState(this));
    }

    private void Update()
    {
        _sm.currentState.Update();

        if (Input.GetKeyDown(KeyCode.Q))
        {
            _sm.ChangeState(_moveState);
        }

        if (Input.GetKeyDown(KeyCode.W))
        {
            _sm.ChangeState(_idileState);
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            _sm.ChangeState(_attackState);
        }
    }
}
