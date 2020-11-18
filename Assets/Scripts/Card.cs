﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card {

	public string Rank { get; }
	public string Suit { get; }
	public string Value { get; }

	public Card(string rank, string suit) {
		this.Rank = rank;
		this.Suit = suit;
	}

	public override string ToString() {
		return $"{Rank} of {Suit}";
	}
}
