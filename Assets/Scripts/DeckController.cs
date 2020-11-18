using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckController : MonoBehaviour {

    private Deck deck;

	public void Start() {
		deck = new Deck();
	}
}
