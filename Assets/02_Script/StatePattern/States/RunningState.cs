using UnityEngine;

public class RunngingState : IState
{
    PlayerController player;

    //생성자 
    public RunngingState(PlayerController player)
    {
        this.player = player;
    }

    public void Enter()
    {
        player.GetComponent<Animator>().SetTrigger("Run");
    }

    public void Excute()
    {

    }

    public void Exit()
    {

    }
}
