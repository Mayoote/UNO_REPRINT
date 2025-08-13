using Godot;
using System;

// Author : Maïtson PIERRE

namespace Maitson.PIERRE.UnoProject.Managers {
	
	public partial class GameManager : Node2D
	{
		public override void _Ready()
		{
			DeckData lDeckData = new DeckData();
			Deck lDeck = new Deck(lDeckData);
			
			GD.Print(lDeck.cards[30].cardData.cardColor); //Red Card
			GD.Print(lDeck.cards[70].cardData.cardColor); //Green Card
			GD.Print(lDeck.cards[50].cardData.cardColor); //Green Card
			GD.Print(lDeck.cards[90].cardData.cardColor); // Yellow Card
			GD.Print(lDeck.cards[100].cardData.cardColor); // Colorless Card
			GD.Print(lDeck.cards.Count); // 108
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
