using Godot;
using System;

// Author : Maïtson PIERRE

namespace Maitson.PIERRE.UnoProject.Managers {
	
	public partial class GameManager : Node2D
	{
		public override void _Ready()
		{
			DeckData lDeckData = new DeckData();
			//lDeckData.numberOneAmount = 12; // j'peux tweak le nombre comme je veux
			Deck lDeck = new Deck(lDeckData);
			
			GD.Print(lDeck.cards[2]);
			GD.Print(lDeck.cards.Count);
		}

		public override void _Process(double pDelta)
		{
			float lDelta = (float)pDelta;

		}

		protected override void Dispose(bool pDisposing)
		{

		}
	}
}
