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

    public void add_character(BaseCharacter player)
    {
        
    }
}
