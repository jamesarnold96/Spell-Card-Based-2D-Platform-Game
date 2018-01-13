using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOnCollide : MonoBehaviour {
	void OnCollisionEnter2D(Collision2D col) {
		if(col.gameObject.tag == "Fire")
		{
			Destroy(col.gameObject);
		}
	}
}

