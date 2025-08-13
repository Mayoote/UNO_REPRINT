using Godot;
using System;
using System.Collections.Generic;
using System.Net;

// Author : Maïtson PIERRE

namespace Maitson.PIERRE.UnoProject {
	
	public partial class Deck
	{
		public DeckData deckData;
		public List<Card> cards = new List<Card>();
		
		public Deck(DeckData pDeckData)
		{
			// pDeckData.numberZeros = new NumberZero[pDeckData.numberZeroAmount];
			// pDeckData.numberOnes = new NumberOne[pDeckData.numberOneAmount];
			// pDeckData.numberTwos = new NumberTwo[pDeckData.numberTwoAmount];
			// pDeckData.numberFours = new NumberFour[pDeckData.numberFourAmount];
			// pDeckData.numberFives = new NumberFive[pDeckData.numberFiveAmount];
			// pDeckData.numberSixes = new NumberSix[pDeckData.numberSixAmount];
			// pDeckData.numberSevens = new NumberSeven[pDeckData.numberSevenAmount];
			// pDeckData.numberEights = new NumberEight[pDeckData.numberEightAmount];
			// pDeckData.numberNines = new NumberNine[pDeckData.numberNineAmount];
			//
			// pDeckData.reverses = new Reverse[pDeckData.reverseAmount];
			// pDeckData.skips = new Skip[pDeckData.skipAmount];
			// pDeckData.wilds = new Wild[pDeckData.wildAmount];
			// pDeckData.wildPlusFours = new WildPlusFour[pDeckData.wildPlusFoursAmount];
			//
			// for (int i = 0; i < pDeckData.numberOnes.Length; i++)
			// {
			// 	pDeckData.numberOnes[i] = new NumberOne();
			// }
			deckData = pDeckData;
			CreateDeck(deckData);
		}
		
		private void CreateDeck(DeckData pDeckData)
		{
			Card lCard;
			for (int a = 0; a < pDeckData.numberZeroAmount; a++)
			{
				lCard = new NumberZero();
				cards.Add(lCard);
			}
			
			for (int b = 0; b < pDeckData.numberOneAmount; b++)
				{
				lCard = new NumberOne();
				cards.Add(lCard);
				}
			for (int c = 0; c < pDeckData.numberTwoAmount; c++)
				{
				lCard = new NumberZero();
				cards.Add(lCard);
				}
		}
	}
}
