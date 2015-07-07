using UnityEngine;
using System.Collections;

public class SquareData {

    private BaseCharacter character;
    private double square_size_occupied;

    public double Square_size_occupied
    {
        get { return square_size_occupied; }
        set { square_size_occupied = value; }
    }

    public BaseCharacter Character
    {
        get { return character; }
        set { character = value; }
    }

    public static SquareData create_squad(SquareData new_squad, BaseCharacter leader)
    {
        new_squad.Character = leader;
        new_squad.Square_size_occupied = leader.Race.Square_Size;
        return new_squad;
    }
}
