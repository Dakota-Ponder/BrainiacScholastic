
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour

{
    // play buttons
    public Button dealBtn;
    public Button standBtn;
    public Button hitBtn;
    public Button bet25;
    public Button exit;
    public Button reload;

    // display texts
    public TMP_Text cash;
    public TMP_Text bet;
    public TMP_Text playerHand;
    public TMP_Text dealerHand;
    public TMP_Text win;

    // dealer hidden card
    public GameObject hideCard;

    // player and dealer scripts
    public playerScript player;
    public playerScript dealer;
    
    // betting pot
    public int pot = 0;


    // Start is called before the first frame update
    void Start()
    {
        // set unwanted button and text visibility to false
        dealerHand.gameObject.SetActive(false);
        hitBtn.gameObject.SetActive(false);
        standBtn.gameObject.SetActive(false);
        win.gameObject.SetActive(false);
        hideCard.gameObject.SetActive(false);

        // reset's everyone's hand
        player.resetHand();
        dealer.resetHand();

        // get button clicks
        dealBtn.onClick.AddListener(() => DealClicked());           // deal
        standBtn.onClick.AddListener(() => StandClicked());         // stand
        hitBtn.onClick.AddListener(() => HitClicked());             // hit
        bet25.onClick.AddListener(() => betMoney());                // bet
        exit.onClick.AddListener(() => exitClicked());              // quit
        reload.onClick.AddListener(() => reloadClicked());          // reload

    }

    // starts the round
    private void DealClicked()
    {
        // resets player hand
        player.resetHand();
        dealer.resetHand();

        // shuffle deck
        GameObject.Find("Deck").GetComponent<Deck>().shuffle();

        // starts each players hand
        player.startHand();
        dealer.startHand();

        // text visibility
        win.gameObject.SetActive(false);
        dealerHand.gameObject.SetActive(false);

        // dealer's first card visibility
        hideCard.GetComponent<Renderer>().enabled = true;
        hideCard.gameObject.SetActive(true);

        // button visibility
        dealBtn.gameObject.SetActive(false);
        bet25.gameObject.SetActive(false);
        standBtn.gameObject.SetActive(true);
        hitBtn.gameObject.SetActive(true);

        // score display
        playerHand.text = "Player: " + player.handValue.ToString();

        if (player.handValue == 21) 
        {
            checkRound();
        }

    }

    private void StandClicked()
    {
        // shows dealer's first card and hand value
        hideCard.gameObject.SetActive(false);
        dealerHand.gameObject.SetActive(true);
        // removes hit and stand button
        hitBtn.gameObject.SetActive(false);
        standBtn.gameObject.SetActive(false);
        // calls dealer hit for dealer's turn
        dealerHit();
        // updates dealer scores
        dealerHand.text = "Dealer: " + dealer.handValue.ToString();
        // checks win conditions
        checkRound();
    }

    // button for hit
    private void HitClicked()
    {
        // allows player to hit as long as card is under 8
        // updates player's score and checks win condition
        if (player.cardIndex <= 8)
        {
            player.getCard();
            playerHand.text = "Player: " + player.handValue.ToString();

            if (player.handValue > 20) 
                checkRound();
        }
    }

    // dealer's turn to hit
    private void dealerHit()
    {
        // while loop to keep the dealer hitting until 16 or bust
        // also checks win conditon
        while (dealer.handValue < 16 && dealer.cardIndex < 10)
        {
            dealer.getCard();

            if (dealer.handValue > 20) 
                checkRound();
        }
    }

    // bet button
    private void betMoney()
    {
        if (player.getMoney() > 0)
        {
            pot += 25;
            player.addMoney(-25);
            bet.text = "Bet: $" + pot.ToString();
            cash.text = "$" + player.getMoney().ToString();
        }

    }

    // check to see the round winner
    void checkRound()
    {
        bool player21 = player.handValue == 21;
        bool dealer21 = dealer.handValue == 21;
        bool playerBust = player.handValue > 21;
        bool dealerBust = dealer.handValue > 21;


        bool over = true;

        // if both dealer and player busts
        if ((playerBust && dealerBust) || (player.handValue == dealer.handValue))
        {
            win.text = "Push";

        }
        // if plaayer wins
        else if (dealerBust || (player.handValue > dealer.handValue && !playerBust))
        {
            win.text = "Player Wins!";
            player.addMoney(pot*2);
        }
        // if dealer wins
        else if (playerBust || (dealer.handValue > player.handValue && !dealerBust))
        {
            win.text = "Dealer Wins!";
        }
        else
        {
            over = false;
        }

        // if round is over
        if (over)
        {
            
            // displays dealers final score
            dealerHand.text = "Dealer: " + dealer.handValue.ToString();
            // changes button visibility
            hitBtn.gameObject.SetActive(false);
            standBtn.gameObject.SetActive(false);
            bet25.gameObject.SetActive(true);
            // displays win message and deal button to go again
            win.gameObject.SetActive(true);
            dealBtn.gameObject.SetActive(true);
            // displays dealer's hand and value
            dealerHand.gameObject.SetActive(true);
            hideCard.GetComponent<Renderer>().enabled = false;
            // update plays cash
            cash.text = "$" + player.getMoney().ToString();

            pot = 0;
            bet.text = "Bet: $" + pot.ToString();
        }

    }

    void exitClicked()
    {
        Application.Quit();
    }

    void reloadClicked()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
