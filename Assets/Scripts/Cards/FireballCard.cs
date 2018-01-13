using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballCard : Card {

	public FireballCard() {}

	public override Sprite getImage() {
		//return Resources.Load("Assets/test.jpg", typeof(Sprite)) as Sprite;
		return Resources.Load<Sprite>("images/test2");
	}

	public override void OnClickCard() {
		GameObject prefab = Resources.Load<GameObject>("prefabs/FireballPrefab");
		if (prefab == null) {
			Debug.Log("NULLLLLLLL");
		}
		prefab.AddComponent(typeof(DestroyOnCollide));
		ProjectileSpell.Fire(prefab, GetPlayerTransform(), 10 , getFacing());
	}
}
