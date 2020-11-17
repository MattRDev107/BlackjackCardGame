using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Deck{
	
	public Card[] deck;
	public int[] randomDrawOrder;
	public int currentCard;
	private int numberOfCards = 52;

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

	public void ShuffleDeck() {
		System.Random rand = new System.Random();
		int n = randomDrawOrder.Length - 1;

		for (int i = n; i > 0; i--) {
			int j = rand.Next(0, i);
			int temp = randomDrawOrder[i];
			randomDrawOrder[i] = randomDrawOrder[j];
			randomDrawOrder[j] = temp;
		}
	}

	public void DrawCard (){

	}

	public override string ToString() {
		string output = null;
		foreach(Card card in deck) {
			output += card.ToString() + ", ";
		}
		return output;
	}

	//? Don't forget to remove this method when done with Shuffle Deck function
	public string RandomOrderToString() {
		string output = null;
		foreach(int num in randomDrawOrder) {
			output += num.ToString() + " ";
		}
		return output;
	}
}
