using UnityEngine;

public class StateMachine //깔끔하게 스테이트만 관리하기위해 monobehavior은 뺌 
{
    public IState CurrnetState { get; private set; }//현재 상태는 읽을수는 있지만 셋팅은 못하게

    PlayerController player; //현재 상태에 따라 움직이도록

    //관리할 State들
    public IdleState idleState;
    public RunngingState runngingState;
    public DeathState deathState;
    public AttackState attackState;


    //monovehavior가 아니기 때문에 생성자 필요 
    public StateMachine(PlayerController player)
    {
        this.player = player;

        //각 스테이트 생성 
        idleState = new IdleState(player);
        runngingState = new RunngingState(player);
        deathState = new DeathState(player);
        attackState = new AttackState(player);
    }

    public void Initialize(IState state)
    {
        CurrnetState = state;
        state.Enter();
    }

    public void TransitionTo(IState nextState)
    {
        CurrnetState.Exit();
        CurrnetState = nextState;
        CurrnetState.Enter();
    }

    public void Excute()
    {
        CurrnetState.Excute();
    }
}
