using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BaseSquad
{
    private SquareData[,] squad = new SquareData[3, 3];
    private BaseCharacter squad_leader;
    private int squad_size;
    private List<BaseCharacter> squad_members = new List<BaseCharacter>();

    public int Squad_size
    {
        get { return squad_size; }
        set { squad_size = value; }
    }

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
            squad_leader = leader;
            squad_size = leader.Race.Size;
            squad_members.Add(leader);
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

    public void add_character(BaseCharacter c, int x, int y)
    {
        if (character_add(c, x, y))
        {
            squad[x, y].Character = c;
            this.squad_size = this.squad_size + c.Race.Size;
            add_big_character(c, x, y);
            squad_members.Add(c);
        }
    }

    public void remove_member(BaseCharacter x)
    {
        if (remove_leader(x))
        {
            foreach (BaseCharacter s in squad_members)
            {
                if (s == x)
                {
                    squad_members.Remove(s);
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (squad[i, j].Character == x)
                    {
                        squad[i, j].Square_size_occupied = squad[i, j].Square_size_occupied - squad[i, j].Character.Race.Square_Size;
                        squad[i, j].Character = null;
                        delete_extra_space(x, i, j);
                    }
                }
            }
            squad_size = squad_size - x.Race.Size;
        }
    }

    public bool character_add(BaseCharacter c, int x, int y)
    {
        bool c1 = squad[x, y].Character == null;
        bool c2 = squad[x, y].Square_size_occupied + c.Race.Square_Size == 1;
        bool c3 = this.squad_size + c.Race.Size <= 5 || this.squad_size + c.Race.Size > 0;
        bool c4;
        if (x == 0 && y == 0)
        {
            bool down = squad[x + 1, y].Square_size_occupied + c.Race.Extra_Size <= 1;
            bool right = squad[x, y + 1].Square_size_occupied + c.Race.Extra_Size <= 1;
            bool down_right = squad[x + 1, y + 1].Square_size_occupied + c.Race.Extra_Size <= 1;
            c4 = down && right && down_right;
        }
        else if (x == 0 && y == 1)
        {
            bool down = squad[x + 1, y].Square_size_occupied + c.Race.Extra_Size <= 1;
            bool right = squad[x, y + 1].Square_size_occupied + c.Race.Extra_Size <= 1;
            bool left = squad[x, y - 1].Square_size_occupied + c.Race.Extra_Size <= 1;
            bool down_left = squad[x + 1, y - 1].Square_size_occupied + c.Race.Extra_Size <= 1;
            bool down_right = squad[x + 1, y + 1].Square_size_occupied + c.Race.Extra_Size <= 1;
            c4 = down && right && down_left && down_right;
        }
        else if (x == 0 && y == 2)
        {
            bool down = squad[x + 1, y].Square_size_occupied + c.Race.Extra_Size <= 1;
            bool left = squad[x, y - 1].Square_size_occupied + c.Race.Extra_Size <= 1;
            bool down_left = squad[x + 1, y - 1].Square_size_occupied + c.Race.Extra_Size <= 1;
            c4 = down && left && down_left;
        }
        else if (x == 1 && y == 0)
        {
            bool down = squad[x + 1, y].Square_size_occupied + c.Race.Extra_Size <= 1;
            bool right = squad[x, y + 1].Square_size_occupied + c.Race.Extra_Size <= 1;
            bool up = squad[x - 1, y].Square_size_occupied + c.Race.Extra_Size <= 1;
            bool up_right = squad[x - 1, y + 1].Square_size_occupied + c.Race.Extra_Size <= 1;
            bool down_right = squad[x + 1, y + 1].Square_size_occupied + c.Race.Extra_Size <= 1;
            c4 = down && right && up_right && down_right;
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

            c4 = down && right && left && up_right && up_left && down_right && up && down_left;
        }
        else if (x == 1 && y == 2)
        {
            bool down = squad[x + 1, y].Square_size_occupied + c.Race.Extra_Size <= 1;
            bool up = squad[x - 1, y].Square_size_occupied + c.Race.Extra_Size <= 1;
            bool left = squad[x, y - 1].Square_size_occupied + c.Race.Extra_Size <= 1;
            bool up_left = squad[x - 1, y - 1].Square_size_occupied + c.Race.Extra_Size <= 1;
            bool down_left = squad[x + 1, y - 1].Square_size_occupied + c.Race.Extra_Size <= 1;
            c4 = down && up && left && up_left && down_left;
        }
        else if (x == 2 && y == 0)
        {
            bool right = squad[x, y + 1].Square_size_occupied + c.Race.Extra_Size <= 1;
            bool up = squad[x - 1, y].Square_size_occupied + c.Race.Extra_Size <= 1;
            bool up_right = squad[x - 1, y + 1].Square_size_occupied + c.Race.Extra_Size <= 1;
            c4 = right && up && up_right;
        }
        else if (x == 2 && y == 1)
        {
            bool right = squad[x, y + 1].Square_size_occupied + c.Race.Extra_Size <= 1;
            bool up = squad[x - 1, y].Square_size_occupied + c.Race.Extra_Size <= 1;
            bool left = squad[x, y - 1].Square_size_occupied + c.Race.Extra_Size <= 1;
            bool up_right = squad[x - 1, y + 1].Square_size_occupied + c.Race.Extra_Size <= 1;
            bool up_left = squad[x - 1, y - 1].Square_size_occupied + c.Race.Extra_Size <= 1;
            c4 = right && up && left && up_left && up_right;
        }
        else if (x == 2 && y == 2)
        {
            bool up = squad[x - 1, y].Square_size_occupied + c.Race.Extra_Size <= 1;
            bool left = squad[x, y - 1].Square_size_occupied + c.Race.Extra_Size <= 1;
            bool up_left = squad[x - 1, y - 1].Square_size_occupied + c.Race.Extra_Size <= 1;
            c4 = up && left && up_left;
        }
        else
        {
            c4 = false;
        }
        return c1 && c2 && c3 && c4;
    }

    private void add_big_character(BaseCharacter c, int x, int y)
    {
        if (character_add(c, x, y))
        {
            if (x == 0 && y == 0)
            {
                squad[x + 1, y].Square_size_occupied = squad[x + 1, y].Square_size_occupied + c.Race.Extra_Size;
                squad[x, y + 1].Square_size_occupied = squad[x, y + 1].Square_size_occupied + c.Race.Extra_Size;
                squad[x + 1, y + 1].Square_size_occupied = squad[x + 1, y + 1].Square_size_occupied + c.Race.Extra_Size;
            }
            else if (x == 0 && y == 1)
            {
                squad[x + 1, y].Square_size_occupied = squad[x + 1, y].Square_size_occupied + c.Race.Extra_Size;
                squad[x, y + 1].Square_size_occupied = squad[x, y + 1].Square_size_occupied + c.Race.Extra_Size;
                squad[x, y - 1].Square_size_occupied = squad[x, y - 1].Square_size_occupied + c.Race.Extra_Size;
                squad[x + 1, y - 1].Square_size_occupied = squad[x + 1, y - 1].Square_size_occupied + c.Race.Extra_Size;
                squad[x + 1, y + 1].Square_size_occupied = squad[x + 1, y + 1].Square_size_occupied + c.Race.Extra_Size;
            }
            else if (x == 0 && y == 2)
            {
                squad[x + 1, y].Square_size_occupied = squad[x + 1, y].Square_size_occupied + c.Race.Extra_Size;
                squad[x, y - 1].Square_size_occupied = squad[x, y - 1].Square_size_occupied + c.Race.Extra_Size;
                squad[x + 1, y - 1].Square_size_occupied = squad[x + 1, y - 1].Square_size_occupied + c.Race.Extra_Size;
            }
            else if (x == 1 && y == 0)
            {
                squad[x + 1, y].Square_size_occupied = squad[x + 1, y].Square_size_occupied + c.Race.Extra_Size;
                squad[x, y + 1].Square_size_occupied = squad[x, y + 1].Square_size_occupied + c.Race.Extra_Size;
                squad[x - 1, y].Square_size_occupied = squad[x - 1, y].Square_size_occupied + c.Race.Extra_Size;
                squad[x - 1, y + 1].Square_size_occupied = squad[x - 1, y + 1].Square_size_occupied + c.Race.Extra_Size;
                squad[x + 1, y + 1].Square_size_occupied = squad[x + 1, y + 1].Square_size_occupied + c.Race.Extra_Size;
            }
            else if (x == 1 && y == 1)
            {
                squad[x + 1, y].Square_size_occupied = squad[x + 1, y].Square_size_occupied + c.Race.Extra_Size;
                squad[x, y + 1].Square_size_occupied = squad[x, y + 1].Square_size_occupied + c.Race.Extra_Size;
                squad[x - 1, y].Square_size_occupied = squad[x - 1, y].Square_size_occupied + c.Race.Extra_Size;
                squad[x, y - 1].Square_size_occupied = squad[x, y - 1].Square_size_occupied + c.Race.Extra_Size;
                squad[x - 1, y + 1].Square_size_occupied = squad[x - 1, y + 1].Square_size_occupied + c.Race.Extra_Size;
                squad[x - 1, y - 1].Square_size_occupied = squad[x - 1, y - 1].Square_size_occupied + c.Race.Extra_Size;
                squad[x + 1, y + 1].Square_size_occupied = squad[x + 1, y + 1].Square_size_occupied + c.Race.Extra_Size;
                squad[x + 1, y - 1].Square_size_occupied = squad[x + 1, y - 1].Square_size_occupied + c.Race.Extra_Size;
            }
            else if (x == 1 && y == 2)
            {
                squad[x + 1, y].Square_size_occupied = squad[x + 1, y].Square_size_occupied + c.Race.Extra_Size;
                squad[x - 1, y].Square_size_occupied = squad[x - 1, y].Square_size_occupied + c.Race.Extra_Size;
                squad[x, y - 1].Square_size_occupied = squad[x, y - 1].Square_size_occupied + c.Race.Extra_Size;
                squad[x - 1, y - 1].Square_size_occupied = squad[x - 1, y - 1].Square_size_occupied + c.Race.Extra_Size;
                squad[x + 1, y - 1].Square_size_occupied = squad[x + 1, y - 1].Square_size_occupied + c.Race.Extra_Size;
            }
            else if (x == 2 && y == 0)
            {
                squad[x, y + 1].Square_size_occupied = squad[x, y + 1].Square_size_occupied + c.Race.Extra_Size;
                squad[x - 1, y].Square_size_occupied = squad[x - 1, y].Square_size_occupied + c.Race.Extra_Size;
                squad[x - 1, y + 1].Square_size_occupied = squad[x - 1, y + 1].Square_size_occupied + c.Race.Extra_Size;
            }
            else if (x == 2 && y == 1)
            {
                squad[x, y + 1].Square_size_occupied = squad[x, y + 1].Square_size_occupied + c.Race.Extra_Size;
                squad[x - 1, y].Square_size_occupied = squad[x - 1, y].Square_size_occupied + c.Race.Extra_Size;
                squad[x, y - 1].Square_size_occupied = squad[x, y - 1].Square_size_occupied + c.Race.Extra_Size;
                squad[x - 1, y + 1].Square_size_occupied = squad[x - 1, y + 1].Square_size_occupied + c.Race.Extra_Size;
                squad[x - 1, y - 1].Square_size_occupied = squad[x - 1, y - 1].Square_size_occupied + c.Race.Extra_Size;
            }
            else if (x == 2 && y == 2)
            {
                squad[x - 1, y].Square_size_occupied = squad[x - 1, y].Square_size_occupied + c.Race.Extra_Size;
                squad[x, y - 1].Square_size_occupied = squad[x, y - 1].Square_size_occupied + c.Race.Extra_Size;
                squad[x - 1, y - 1].Square_size_occupied = squad[x - 1, y - 1].Square_size_occupied + c.Race.Extra_Size;
            }
            else
            {

            }
        }
    }

    public bool remove_leader(BaseCharacter protagonist)
    {
        bool c1 = protagonist.Is_a_protagonist;
        bool c2 = squad_leader == protagonist;
        return c1 && c2;
    }

    private void delete_extra_space(BaseCharacter c, int x, int y)
    {
        if (character_add(c, x, y))
        {
            if (x == 0 && y == 0)
            {
                squad[x + 1, y].Square_size_occupied = squad[x + 1, y].Square_size_occupied - c.Race.Extra_Size;
                squad[x, y + 1].Square_size_occupied = squad[x, y + 1].Square_size_occupied - c.Race.Extra_Size;
                squad[x + 1, y + 1].Square_size_occupied = squad[x + 1, y + 1].Square_size_occupied - c.Race.Extra_Size;
            }
            else if (x == 0 && y == 1)
            {
                squad[x + 1, y].Square_size_occupied = squad[x + 1, y].Square_size_occupied - c.Race.Extra_Size;
                squad[x, y + 1].Square_size_occupied = squad[x, y + 1].Square_size_occupied - c.Race.Extra_Size;
                squad[x, y - 1].Square_size_occupied = squad[x, y - 1].Square_size_occupied - c.Race.Extra_Size;
                squad[x + 1, y - 1].Square_size_occupied = squad[x + 1, y - 1].Square_size_occupied - c.Race.Extra_Size;
                squad[x + 1, y + 1].Square_size_occupied = squad[x + 1, y + 1].Square_size_occupied - c.Race.Extra_Size;
            }
            else if (x == 0 && y == 2)
            {
                squad[x + 1, y].Square_size_occupied = squad[x + 1, y].Square_size_occupied - c.Race.Extra_Size;
                squad[x, y - 1].Square_size_occupied = squad[x, y - 1].Square_size_occupied - c.Race.Extra_Size;
                squad[x + 1, y - 1].Square_size_occupied = squad[x + 1, y - 1].Square_size_occupied - c.Race.Extra_Size;
            }
            else if (x == 1 && y == 0)
            {
                squad[x + 1, y].Square_size_occupied = squad[x + 1, y].Square_size_occupied - c.Race.Extra_Size;
                squad[x, y + 1].Square_size_occupied = squad[x, y + 1].Square_size_occupied - c.Race.Extra_Size;
                squad[x - 1, y].Square_size_occupied = squad[x - 1, y].Square_size_occupied - c.Race.Extra_Size;
                squad[x - 1, y + 1].Square_size_occupied = squad[x - 1, y + 1].Square_size_occupied - c.Race.Extra_Size;
                squad[x + 1, y + 1].Square_size_occupied = squad[x + 1, y + 1].Square_size_occupied - c.Race.Extra_Size;
            }
            else if (x == 1 && y == 1)
            {
                squad[x + 1, y].Square_size_occupied = squad[x + 1, y].Square_size_occupied - c.Race.Extra_Size;
                squad[x, y + 1].Square_size_occupied = squad[x, y + 1].Square_size_occupied - c.Race.Extra_Size;
                squad[x - 1, y].Square_size_occupied = squad[x - 1, y].Square_size_occupied - c.Race.Extra_Size;
                squad[x, y - 1].Square_size_occupied = squad[x, y - 1].Square_size_occupied - c.Race.Extra_Size;
                squad[x - 1, y + 1].Square_size_occupied = squad[x - 1, y + 1].Square_size_occupied - c.Race.Extra_Size;
                squad[x - 1, y - 1].Square_size_occupied = squad[x - 1, y - 1].Square_size_occupied - c.Race.Extra_Size;
                squad[x + 1, y + 1].Square_size_occupied = squad[x + 1, y + 1].Square_size_occupied - c.Race.Extra_Size;
                squad[x + 1, y - 1].Square_size_occupied = squad[x + 1, y - 1].Square_size_occupied - c.Race.Extra_Size;
            }
            else if (x == 1 && y == 2)
            {
                squad[x + 1, y].Square_size_occupied = squad[x + 1, y].Square_size_occupied - c.Race.Extra_Size;
                squad[x - 1, y].Square_size_occupied = squad[x - 1, y].Square_size_occupied - c.Race.Extra_Size;
                squad[x, y - 1].Square_size_occupied = squad[x, y - 1].Square_size_occupied - c.Race.Extra_Size;
                squad[x - 1, y - 1].Square_size_occupied = squad[x - 1, y - 1].Square_size_occupied - c.Race.Extra_Size;
                squad[x + 1, y - 1].Square_size_occupied = squad[x + 1, y - 1].Square_size_occupied - c.Race.Extra_Size;
            }
            else if (x == 2 && y == 0)
            {
                squad[x, y + 1].Square_size_occupied = squad[x, y + 1].Square_size_occupied - c.Race.Extra_Size;
                squad[x - 1, y].Square_size_occupied = squad[x - 1, y].Square_size_occupied - c.Race.Extra_Size;
                squad[x - 1, y + 1].Square_size_occupied = squad[x - 1, y + 1].Square_size_occupied - c.Race.Extra_Size;
            }
            else if (x == 2 && y == 1)
            {
                squad[x, y + 1].Square_size_occupied = squad[x, y + 1].Square_size_occupied - c.Race.Extra_Size;
                squad[x - 1, y].Square_size_occupied = squad[x - 1, y].Square_size_occupied - c.Race.Extra_Size;
                squad[x, y - 1].Square_size_occupied = squad[x, y - 1].Square_size_occupied - c.Race.Extra_Size;
                squad[x - 1, y + 1].Square_size_occupied = squad[x - 1, y + 1].Square_size_occupied - c.Race.Extra_Size;
                squad[x - 1, y - 1].Square_size_occupied = squad[x - 1, y - 1].Square_size_occupied - c.Race.Extra_Size;
            }
            else if (x == 2 && y == 2)
            {
                squad[x - 1, y].Square_size_occupied = squad[x - 1, y].Square_size_occupied - c.Race.Extra_Size;
                squad[x, y - 1].Square_size_occupied = squad[x, y - 1].Square_size_occupied - c.Race.Extra_Size;
                squad[x - 1, y - 1].Square_size_occupied = squad[x - 1, y - 1].Square_size_occupied - c.Race.Extra_Size;
            }
            else
            {

            }
        }
    }
}
