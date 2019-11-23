using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats
{
    /*We are of no need for enumerators.
     * If we simply have these stats as integers
     * we can check if either of those are zero,
     * which opens a lot of doors.
     * Sometimes you want to put the less amount of work
     * to get a desired result.
     * 
     * Also, using the Header attribute will display
     * which stats are defensive, and which stats are 
     * offsensive.
     * 
     * ~Tyrease Teer
     */

    //All stats
    [Header("Defensive Stats")]
    public int HP, DRAIN;

    [Header("Offensive Stats")]
    public int ATTACK, CHARGE;
}
