using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Deck", menuName = "Deck")]
public class Deck : ScriptableObject
{
    //Name of deck
    public string m_Name;

    //What the deck is
    [TextArea]
    public string deckDescription;

    //The amount of cards it currently holds
    public List<Card> card = new List<Card>();
}
