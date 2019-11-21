using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats
{
    public enum cardStats
    {
        Offensive,
        Defensive
    }

    public cardStats typeStats;

    public enum Offensive
    {
        ATTACK,
        CHARGE
    }

    public Offensive offensivesStats;

    public string m_offensiveValue;

    public enum Defensive
    {
        HP,
        DRAIN
    }

    public Defensive defensivesStats;

    public string m_defensiveValue;
    
    //All stats
    public int HP, DRAIN, ATTACK, CHARGE;
}
