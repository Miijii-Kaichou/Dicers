using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Card : ScriptableObject
{
    //Name of card
    public string m_Name;

    //Stats
    //We don't have to put a lot of stuff in card.
    //This is taking class implementation modularly, which 
    //makes it easier to track down things
    //without a lot of stuff.
    public Stats stats;

    //Card Description
    [TextArea]
    public string cardDescription;

    //Effects
    public Effect[] cardEffects = new Effect[6];

    //CoverArt
    public Image cardCoverArt;
}
