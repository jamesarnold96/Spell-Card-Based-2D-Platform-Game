using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PunchCard : Card {
	public PunchCard() {}

	public override Sprite getImage() {
		//return Resources.Load("Assets/test.jpg", typeof(Sprite)) as Sprite;
		return Resources.Load<Sprite>("images/test");
	}

	public override void OnClickCard() {
		Debug.Log("Punch");
		//throw new System.NotImplementedException();
	}
}
