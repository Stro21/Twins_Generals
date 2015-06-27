using UnityEngine;
using System.Collections;

public class BaseStatus : MonoBehaviour
{
    private Status status;
    private string status_effect;

    public string Status_effect
    {
        get { return status_effect; }
        set { status_effect = value; }
    }
    public Status Status1
    {
        get { return status; }
        set { status = value; }
    }
    
    public enum Status
    {
        Normal,
        Paralyze,
        Frozen,
        Burn,
        Sleep,
        Attack_Up,
        Attack_Down,
        Defence_Up,
        Defence_Down
    }
}
