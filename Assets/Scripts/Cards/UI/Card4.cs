using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card4 : MonoBehaviour {

	Image myimage;
	Card currentCard;
	private SpriteRenderer spriteR;
	private Sprite[] sprites;

	private void Start() {
		
	}

	private void Update() {

	}

	public void setCard(Card card) {
		currentCard = card;
	}

	public Image getImage() {
		return GetComponent<Image>();
	}

	public void onClick() {
		currentCard.OnClickCard();
		GameObject.Find("Card1Image").GetComponent<TutorialGame>().SendMessage("draw", 4);

	}
}
