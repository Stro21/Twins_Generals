using UnityEngine;
using System.Collections;

public class BaseSquad
{
    private SquareData[,] squad = new SquareData[3, 3];
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
        bool c3;
        if (x == 0 && y == 0)
        {
            bool down = squad[x + 1, y].Square_size_occupied + c.Race.Extra_Size <= 1;
            bool right = squad[x, y + 1].Square_size_occupied + c.Race.Extra_Size <= 1;
            bool down_right = squad[x + 1, y + 1].Square_size_occupied + c.Race.Extra_Size <= 1;
            c3 = down && right && down_right;
        }
        else if (x == 0 && y == 1)
        {
            bool down = squad[x + 1, y].Square_size_occupied + c.Race.Extra_Size <= 1;
            bool right = squad[x, y + 1].Square_size_occupied + c.Race.Extra_Size <= 1;
            bool left = squad[x, y - 1].Square_size_occupied + c.Race.Extra_Size <= 1;
            bool down_left = squad[x + 1, y - 1].Square_size_occupied + c.Race.Extra_Size <= 1;
            bool down_right = squad[x + 1, y + 1].Square_size_occupied + c.Race.Extra_Size <= 1;
            c3 = down && right && down_left && down_right;
        }
        else if (x == 0 && y == 2)
        {
            bool down = squad[x + 1, y].Square_size_occupied + c.Race.Extra_Size <= 1;
            bool left = squad[x, y - 1].Square_size_occupied + c.Race.Extra_Size <= 1;
            bool down_left = squad[x + 1, y - 1].Square_size_occupied + c.Race.Extra_Size <= 1;
            c3 = down && left && down_left;
        }
        else if (x == 1 && y == 0)
        {
            bool down = squad[x + 1, y].Square_size_occupied + c.Race.Extra_Size <= 1;
            bool right = squad[x, y + 1].Square_size_occupied + c.Race.Extra_Size <= 1;
            bool up = squad[x - 1, y].Square_size_occupied + c.Race.Extra_Size <= 1;
            bool up_right = squad[x - 1, y + 1].Square_size_occupied + c.Race.Extra_Size <= 1;
            bool down_right = squad[x + 1, y + 1].Square_size_occupied + c.Race.Extra_Size <= 1;
            c3 = down && right && up_right && down_right;
        }
        else if (x == 1 && y == 1)
        {
            bool down = squad[x + 1, y].Square_size_occupied + c.Race.Extra_Size <= 1;
            bool right = squad[x, y + 1].Square_size_occupied + c.Race.Extra_Size <= 1;
            bool up = squad[x - 1, y].Square_size_occupied + c.Race.Extra_Size <= 1;
            bool left = squad[x, y - 1].Square_size_occupied + c.Race.Extra_Size <= 1;
            bool up_right = squad[x - 1, y + 1].Square_size_occupied + c.Race.Extra_Size <= 1;
            bool up_left = squad[x - 1, y - 1].Square_size_occupied + c.Race.Extra_Size <= 1;
            bool down_right = squad[x + 1, y + 1].Square_size_occupied + c.Race.Extra_Size <= 1;
            bool down_left = squad[x + 1, y - 1].Square_size_occupied + c.Race.Extra_Size <= 1;

            c3 = down && right && left && up_right && up_left && down_right && up && down_left;
        }
        else if (x == 1 && y == 2)
        {
            bool down = squad[x + 1, y].Square_size_occupied + c.Race.Extra_Size <= 1;
            bool up = squad[x - 1, y].Square_size_occupied + c.Race.Extra_Size <= 1;
            bool left = squad[x, y - 1].Square_size_occupied + c.Race.Extra_Size <= 1;
            bool up_left = squad[x - 1, y - 1].Square_size_occupied + c.Race.Extra_Size <= 1;
            bool down_left = squad[x + 1, y - 1].Square_size_occupied + c.Race.Extra_Size <= 1;
            c3 = down && up && left && up_left && down_left;
        }
        else if (x == 2 && y == 0)
        {
            bool right = squad[x, y + 1].Square_size_occupied + c.Race.Extra_Size <= 1;
            bool up = squad[x - 1, y].Square_size_occupied + c.Race.Extra_Size <= 1;
            bool up_right = squad[x - 1, y + 1].Square_size_occupied + c.Race.Extra_Size <= 1;
            c3 = right && up && up_right;
        }
        else if (x == 2 && y == 1)
        {
            bool right = squad[x, y + 1].Square_size_occupied + c.Race.Extra_Size <= 1;
            bool up = squad[x - 1, y].Square_size_occupied + c.Race.Extra_Size <= 1;
            bool left = squad[x, y - 1].Square_size_occupied + c.Race.Extra_Size <= 1;
            bool up_right = squad[x - 1, y + 1].Square_size_occupied + c.Race.Extra_Size <= 1;
            bool up_left = squad[x - 1, y - 1].Square_size_occupied + c.Race.Extra_Size <= 1;
            c3 = right && up && left && up_left && up_right;
        }
        else if (x == 2 && y == 2)
        {
            bool up = squad[x - 1, y].Square_size_occupied + c.Race.Extra_Size <= 1;
            bool left = squad[x, y - 1].Square_size_occupied + c.Race.Extra_Size <= 1;
            bool up_left = squad[x - 1, y - 1].Square_size_occupied + c.Race.Extra_Size <= 1;
            c3 = up && left && up_left;
        }
        else
        {
            c3 = false;
        }
        return c1 && c2 && c3;
    }
}
