
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    // PLAYER AND DEALER

    public cardScript cardScript;
    public Deck deckScript;

    public int handValue;
    public int money = 100;

    public GameObject[] hand;

    public int cardIndex = 0;


    List<cardScript> aces = new List<cardScript>();

    // Start is called before the first frame update
    public void startHand()
    {
        getCard();
        getCard();
    }


    public int getCard()
    {
        // get card by using deal card
        int cardValue = deckScript.dealCard(hand[cardIndex].GetComponent<cardScript>());

        hand[cardIndex].GetComponent<Renderer>().enabled = true;
        // add card to hand value
        handValue += cardValue;

        // identify the ace
        if (cardValue == 1)
        {
            aces.Add(hand[cardIndex].GetComponent <cardScript>());
        }

        checkAce();
        cardIndex++;
        return handValue;
    }


    public void checkAce()
    {
        foreach (cardScript x in aces)
        {
            if (handValue + 10 < 22 && x.getValue() == 1)
            {
                x.setValue(11);
                handValue += 10;
            }
            else if (handValue > 21 && x.getValue() == 11)
            {
                x.setValue(1);
                handValue -= 10;
            }
        }
    }

    public void addMoney(int amount)
    {
        money += amount;
    }

    public int getMoney() { return money; }

    public void resetHand()
    {
        for (int i=0; i<hand.Length; i++)
        {
            hand[i].GetComponent<cardScript>().resetCards();
            hand[i].GetComponent<Renderer>().enabled=false;
        }

        cardIndex = 0;
        handValue = 0;
        aces = new List<cardScript>();
    }
}
