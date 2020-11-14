using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Deck{
	
	public Card[] deck;
	public int[] randomDrawOrder;

	private int numberOfCards = 52;
	private System.Random rng = new System.Random();

	public Deck() {
		string[] ranks = { "Ace", "2", "3", "4", "5", "6", "7", "8", "9", "10", "Jack", "Queen", "King" };
		string[] suits = {"Hearts", "Clubs", "Diamonds", "Spades"};
		randomDrawOrder = Enumerable.Range(0, 52).ToArray();
		deck = new Card[numberOfCards];
		int currentCard = 0;
		for (int suitCount = 0; suitCount < suits.Length; suitCount++) {
			for(int rankCount = 0; rankCount < ranks.Length; rankCount++) {
				deck[currentCard] = new Card(ranks[rankCount], suits[suitCount]);
				currentCard++;
			}
		}
	}

	public void SuffleDeck() {

	}

	public void DrawCard (){

	}

	public override string ToString() {
		string output = "";
		foreach(Card card in deck) {
			output += (card.ToString() + ", ");
		}
		return output;
	}
}
