using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckController : MonoBehaviour {

    private Deck deck;

	public void Start() {
		deck = new Deck();
		Debug.Log(deck.ToString());
		Debug.Log(deck.RandomOrderToString());
		deck.ShuffleDeck();
		Debug.Log(deck.RandomOrderToString());
		deck.ShuffleDeck();
		Debug.Log(deck.RandomOrderToString());
		deck.ShuffleDeck();
		Debug.Log(deck.RandomOrderToString());
	}
}
