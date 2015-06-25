using UnityEngine;
using System.Collections;

public class CombatStateMachine : MonoBehaviour
{
    public enum BattleStates
    {
        START,
        INTERRUPT_COMMANDS,
        ATTACKER_ANIMATION,
        DEFENDER_ANIMATION,
        LOSE,
        WIN,
        TIE
    }

    private BattleStates currentstate;

    // Use this for initialization
    void Start()
    {
        currentstate = BattleStates.START;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(currentstate);
        switch (currentstate)
        {
            case(BattleStates.START):
                currentstate = BattleStates.ATTACKER_ANIMATION;
                break;
            case (BattleStates.INTERRUPT_COMMANDS):
                break;
            case (BattleStates.ATTACKER_ANIMATION):
                break;
            case (BattleStates.DEFENDER_ANIMATION):
                break;
            case (BattleStates.TIE):
                break;
            case (BattleStates.LOSE):
                break;
            case (BattleStates.WIN):
                break;
        }
    }
}
