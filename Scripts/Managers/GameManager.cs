using Godot;
using System;

// Author : Maïtson PIERRE

namespace Maitson.PIERRE.UnoProject.Managers {
	
	public partial class GameManager : Node2D
	{
		public override void _Ready()
		{
			DeckData lDeckData = new DeckData();
			lDeckData.numberOneAmount = 12;
			Deck lDeck = new Deck(lDeckData);
			lDeck.deckData.numberZeros[0] = new NumberZero();
			GD.Print(lDeck.deckData.numberOneAmount);
			GD.Print(lDeck.deckData.numberZeros[0]);
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
