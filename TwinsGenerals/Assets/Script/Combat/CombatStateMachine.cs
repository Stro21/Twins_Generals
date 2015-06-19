using UnityEngine;
using System.Collections;

public class CombatStateMachine : MonoBehaviour
{
    public enum BattleStates
    {
        START,
        PLAYERINTERRUPT,
        LOSE,
        WIN,
        TIE
    }

    private BattleStates currentstate;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
