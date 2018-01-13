using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Card {

    private Player _player;

	protected Card() {}

	public abstract void OnClickCard();

	public abstract Sprite getImage();

    protected Transform GetPlayerTransform() {
        return GameObject.Find("Player").GetComponent<Transform>();
    }

    public bool getFacing()
        {
             _player =  GameObject.Find("Player").GetComponent<Player>();
        Debug.Log(_player._isFacingRight.ToString());
        return _player._isFacingRight;
        }

}
