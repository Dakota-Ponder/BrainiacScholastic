
using UnityEngine;

public class cardScript : MonoBehaviour
{
    // card value
    private int value = 0;

    // get value
    public int getValue()
    {
        return value;
    }

    // set value
    public void setValue(int val)
    {
        value = val;
    }

    public void setCard(Sprite card)
    {
        gameObject.GetComponent<SpriteRenderer>().sprite = card;
    }

    public string getCardSprite() 
    { 
        return GetComponent<SpriteRenderer>().sprite.name;
    }

   

    public void resetCards()
    {
        Sprite placeholder = GameObject.Find("Deck").GetComponent<Deck>().getPlaceHolder();
        gameObject.GetComponent<SpriteRenderer>().sprite = placeholder;
        value = 0;
    }

}
