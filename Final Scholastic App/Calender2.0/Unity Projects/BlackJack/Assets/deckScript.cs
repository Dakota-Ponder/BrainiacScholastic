
using UnityEngine;

public class Deck : MonoBehaviour
{
    // Start is called before the first frame update
    public Sprite[] cardSprite;
    public int[] cardValues = new int[53];
    int cardIndex = 0;
    

    void Start()
    {
        getCardValues();
        getCardValues();
        //shuffle();
    }

    // fill array with card values corresponding to card sprites
    public void getCardValues()
    {
        int value = 0;

        for (int i = 0; i < cardSprite.Length; i++) 
        {
            value = i;
            value %= 13;

            if (value > 10 || value == 0)
            {
                value = 10;
            }
            cardValues[i] = value++;
        }
    }

    // shuffle cards sprites
    public void shuffle()
    {    
        Sprite tempCard;

        for (int i = 1;i < cardSprite.Length;i++)
        {
            int randNum = Random.Range(1, 53);

            tempCard = cardSprite[i];
            cardSprite[i] = cardSprite[randNum];
            cardSprite[randNum] = tempCard;

            int tempValue = cardValues[i];
            cardValues[i] = cardValues[randNum];
            cardValues[randNum] = tempValue;
        }
        cardIndex = 1;

    }

    public int dealCard(cardScript card)
    {
        // gets cards from sprite and value array
        card.setCard(cardSprite[cardIndex]);
        card.setValue(cardValues[cardIndex]);

        // inc index
        cardIndex++;
        return card.getValue();
    }

    // function to help reset game; gets first card (placeholder)
    public Sprite getPlaceHolder() 
    {
        return cardSprite[0];
    }


}
