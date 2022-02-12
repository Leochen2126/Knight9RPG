using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player
{
    int health;
    int power;
    string name;

    public Player(int health, int power, string name)
    {
        this.health = health;
        this.power = power;
        this.name = name;
    }

    public void info()
    {
        Debug.Log(health);
        Debug.Log(power);
        Debug.Log(name);

    }

    public void SetHealth(int health) 
    {
        this.health = health;
    }

    public int GetHealth()
    {
        return health;
    }

}
