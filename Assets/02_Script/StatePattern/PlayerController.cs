using UnityEngine;
public class PlayerController :MonoBehaviour
{
    public StateMachine stateMachine;

    private void Awake()
    {
        stateMachine = new StateMachine(this);
        //this는 현재 인스턴스(객체) 자신을 참조하는 키워드.
        //StateMachine 생성자에서 playerController를 받기 때문에 현재 PlayerController의 인스턴스를 this라는 키워드로 넣어준것 
    }


    //idle로 시작
    private void Start()
    {
        stateMachine.Initialize(stateMachine.idleState);
    }

    private void Update()
    {
        stateMachine.Excute(); //현재 state에서 실행할 동작을 실헹 
    }

    //각 상태가 On된다면 
    public void OnIdle()
    {
        stateMachine.TransitionTo(stateMachine.idleState);
    }

    public void OnAttack()
    {
        stateMachine.TransitionTo(stateMachine.attackState);
    }

    public void OnRunning()
    {
        stateMachine.TransitionTo(stateMachine.runngingState);
    }

    public void onDeath()
    {
        stateMachine.TransitionTo(stateMachine.deathState);
    }

}