using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Effect
{
    //What that effect will do.
    [TextArea]
    public string effectDescription;

    /*We can have enumberator effect type
     * here, and use that in an an array 
     * will a given description and type
     */

    public enum EffectType
    {
        EVERY_TURN,
        PLACED,
        BOTH_PLAYERS,
        LEFT_CREATURES,
        MIDDLE_CREATURES,
        RIGHT_CREATURES
    }

    public EffectType effectType;
}
