using UnityEngine;
using System.Collections;

public class BaseSquad
{
    private SquareData[,] squad = new SquareData[3, 3]/* { { null, null, null }, { null, null, null }, { null, null, null } }*/;
    private BaseCharacter squad_leader;

    public BaseSquad(BaseCharacter leader, int x, int y)
    {
        if (correct_new_squad(leader, x, y))
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    squad[x, y].Character = null;
                    squad[x, y].Square_size_occupied = 0;
                }
            }
            squad[x, y] = SquareData.create_squad(squad[x, y], leader);
        }
    }

    public BaseCharacter Squad_leader
    {
        get { return squad_leader; }
        set { squad_leader = value; }
    }
    public SquareData[,] Squad
    {
        get { return squad; }
        set { squad = value; }
    }
    public bool correct_new_squad(BaseCharacter leader, int x, int y)
    {
        return x >= 0 && x < 2 && y >= 0 && y < 2 && leader.Clase.Can_Lead;
    }

    public void add_character()
    {

    }
    public bool character_add(BaseCharacter c, int x, int y)
    {
        bool c1 = squad[x, y].Character == null;
        bool c2 = squad[x, y].Square_size_occupied + c.Race.Size == 1;
        bool c3 = false;
        if (x == 0 && y == 0)
        {
            bool a1 = squad[x + 1, y].Square_size_occupied + c.Race.Extra_Size <= 1;
            bool a2 = squad[x, y + 1].Square_size_occupied + c.Race.Extra_Size <= 1;
            bool a3 = squad[x + 1, y + 1].Square_size_occupied + c.Race.Extra_Size <= 1;
            c3 = a1 && a2 && a3;
        }
        else if (x == 0 && y == 1)
        {
            bool a1 = squad[x + 1, y].Square_size_occupied + c.Race.Extra_Size <= 1;
            bool a2 = squad[x, y + 1].Square_size_occupied + c.Race.Extra_Size <= 1;
            bool a3 = squad[x, y - 1].Square_size_occupied + c.Race.Extra_Size <= 1;
            bool a4 = squad[x + 1, y - 1].Square_size_occupied + c.Race.Extra_Size <= 1;
            bool a5 = squad[x + 1, y + 1].Square_size_occupied + c.Race.Extra_Size <= 1;
            c3 = a1 && a2 && a4 && a5;
        }
        else if (x == 0 && y == 2)
        {
            bool a1 = squad[x + 1, y].Square_size_occupied + c.Race.Extra_Size <= 1;
            bool a2 = squad[x, y - 1].Square_size_occupied + c.Race.Extra_Size <= 1;
            bool a3 = squad[x + 1, y - 1].Square_size_occupied + c.Race.Extra_Size <= 1;
            c3 = a1 && a2 && a3;
        }
        else if (x == 1 && y == 0)
        {
            bool a1 = squad[x + 1, y].Square_size_occupied + c.Race.Extra_Size <= 1;
            bool a2 = squad[x, y + 1].Square_size_occupied + c.Race.Extra_Size <= 1;
            bool a3 = squad[x - 1, y].Square_size_occupied + c.Race.Extra_Size <= 1;
            bool a4 = squad[x - 1, y + 1].Square_size_occupied + c.Race.Extra_Size <= 1;
            bool a5 = squad[x + 1, y + 1].Square_size_occupied + c.Race.Extra_Size <= 1;
            c3 = a1 && a2 && a4 && a5;
        }
        else if (x == 1 && y == 1)
        {
            bool a1 = squad[x + 1, y].Square_size_occupied + c.Race.Extra_Size <= 1;
            bool a2 = squad[x, y + 1].Square_size_occupied + c.Race.Extra_Size <= 1;
            bool a3 = squad[x - 1, y].Square_size_occupied + c.Race.Extra_Size <= 1;
            bool a4 = squad[x - 1, y + 1].Square_size_occupied + c.Race.Extra_Size <= 1;
            bool a5 = squad[x + 1, y + 1].Square_size_occupied + c.Race.Extra_Size <= 1;
            bool a6 = squad[x + 1, y - 1].Square_size_occupied + c.Race.Extra_Size <= 1;
            bool a7 = squad[x - 1, y - 1].Square_size_occupied + c.Race.Extra_Size <= 1;
            bool a8 = squad[x, y - 1].Square_size_occupied + c.Race.Extra_Size <= 1;
            c3 = a1 && a2 && a4 && a5 && a7 && a8;
        }
        return c1 && c2 && c3;
    }
}
