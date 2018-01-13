using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialGame : MonoBehaviour {

	List<Card> deck = new List<Card>();
	//List<Card> cards_in_hand = new List<Card>();
	Card[] cards_in_hand;


	const int NUMBER_OF_CARD_IN_HAND = 5;

	// Use this for initialization
	void Start () {
		
		//Use for loop to add the card into list
		//5 of each cardtype, so 15 cards in total
		for (int i = 0; i < 5; i++) {
			deck.Add(new PunchCard());
			deck.Add(new FireballCard());
			//I forgot the third cardtype we decide to have
		}

		print("Deck set up completed" + deck.Count);

		/*
		 * wrongly implement, jist store the code for future use
		for (int i = 0; i < deck.Count; i++) {
			//set the listener for the cards
			deck[i].onClick.AddListener(delegate { TaskOnClick(deck[i]); });
		}
		*/

		cards_in_hand = new Card[NUMBER_OF_CARD_IN_HAND];
		initdraw(NUMBER_OF_CARD_IN_HAND);

		UpdateCardImage();

	}

	private void TaskOnClick(Card card) {
		//When the card is clicked, call the on click method of the card
		card.OnClickCard();
	}

	public void initdraw(int i) {
		//draw a random card from the deck

		for (int n = 0; n < i; n++) {
			int index = UnityEngine.Random.Range(0, deck.Count - 1);
			cards_in_hand[n] = (deck[index]);
			deck.Remove(deck[index]);
		}
	}

	public void draw(int cardIndex) {
		int index = UnityEngine.Random.Range(0, deck.Count - 1);
		cards_in_hand[cardIndex - 1] = deck[index];
		deck.Remove(deck[index]);
		if (deck.Count == 0) {
			deck.Add(new PunchCard());
		}
		UpdateCardImage();
	}

	public void UpdateCardImage() {
		Image image = GameObject.Find("Card1Image").GetComponent<Card1>().getImage();
		GameObject.Find("Card1Image").GetComponent<Card1>().setCard(cards_in_hand[0]);
		image.sprite = cards_in_hand[0].getImage();
		image = GameObject.Find("Card2Image").GetComponent<Card2>().getImage();
		GameObject.Find("Card2Image").GetComponent<Card2>().setCard(cards_in_hand[1]);
		image.sprite = cards_in_hand[1].getImage();
		image = GameObject.Find("Card3Image").GetComponent<Card3>().getImage();
		GameObject.Find("Card3Image").GetComponent<Card3>().setCard(cards_in_hand[2]);
		image.sprite = cards_in_hand[2].getImage();
		image = GameObject.Find("Card4Image").GetComponent<Card4>().getImage();
		GameObject.Find("Card4Image").GetComponent<Card4>().setCard(cards_in_hand[3]);
		image.sprite = cards_in_hand[3].getImage();
		image = GameObject.Find("Card5Image").GetComponent<Card5>().getImage();
		GameObject.Find("Card5Image").GetComponent<Card5>().setCard(cards_in_hand[4]);
		image.sprite = cards_in_hand[4].getImage();
	}

	/*
	public void destory(Card card) {
		//Destory the card , i.e. remove the card from the deck
		//call when the player uses the card
		deck.Remove(card);
	}
	*/

	// Update is called once per frame
	void Update () {
		
	}
}
