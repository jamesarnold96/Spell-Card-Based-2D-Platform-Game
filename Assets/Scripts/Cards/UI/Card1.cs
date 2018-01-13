using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card1 : MonoBehaviour {

	Image myimage;
	Card currentCard;
	private SpriteRenderer spriteR;
	private Sprite[] sprites;

	private void Start() {
		gameObject.AddComponent(typeof(TutorialGame));
		print("Starting");
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
		GameObject.Find("Card1Image").GetComponent<TutorialGame>().SendMessage("draw", 1);

	}
}
