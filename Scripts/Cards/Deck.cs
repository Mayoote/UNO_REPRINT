using Godot;
using System;
using System.Net;

// Author : Maïtson PIERRE

namespace Maitson.PIERRE.UnoProject {
	
	public partial class Deck
	{
		public DeckData deckData;

		public Deck(DeckData pDeckData)
		{
			pDeckData.numberZeros = new NumberZero[pDeckData.numberZeroAmount];
			pDeckData.numberOnes = new NumberOne[pDeckData.numberOneAmount];
			pDeckData.numberTwos = new NumberTwo[pDeckData.numberTwoAmount];
			pDeckData.numberFours = new NumberFour[pDeckData.numberFourAmount];
			pDeckData.numberFives = new NumberFive[pDeckData.numberFiveAmount];
			pDeckData.numberSixes = new NumberSix[pDeckData.numberSixAmount];
			pDeckData.numberSevens = new NumberSeven[pDeckData.numberSevenAmount];
			pDeckData.numberEights = new NumberEight[pDeckData.numberEightAmount];
			pDeckData.numberNines = new NumberNine[pDeckData.numberNineAmount];

			pDeckData.reverses = new Reverse[pDeckData.reverseAmount];
			pDeckData.skips = new Skip[pDeckData.skipAmount];
			pDeckData.wilds = new Wild[pDeckData.wildAmount];
			pDeckData.wildPlusFours = new WildPlusFour[pDeckData.wildPlusFoursAmount];

			for (int i = 0; i < pDeckData.numberOnes.Length; i++)
			{
				pDeckData.numberOnes[i] = new NumberOne();
			}
			
			deckData = pDeckData;
		}
	}
}
