using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Card : ScriptableObject
{
    //Name of card
    public string m_Name;

    //A card's effect type
    public enum EffectType;
    {
        EVERY_TURN,
        PLACED,
        BOTH_PLAYERS,
        LEFT_CREATURES,
        MIDDLE_CREATURES,
        RIGHT_CREATURES
    }

    public EffectType effectType;

    //Card Description
    [TextArea]
    public string cardDescription;

    //Stats
    public Stats cardStats;
    public string Stats;

    public enum Stats;
    {
        DRAIN,
        CHARGE,
        HEALTH,
        ATTACK
    }


    //Effects
    public Effect[] cardEffects = new Effect[6];

    //What template to used for this card
    public enum CardTemplate;
    {
        DRAIN,
        CHARGE,
        BOTH
    }

    //CoverArt
    public Image cardCoverArt;
}
