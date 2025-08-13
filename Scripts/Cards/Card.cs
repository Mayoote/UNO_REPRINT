using Godot;
using System;

// Author : Maïtson PIERRE

namespace Maitson.PIERRE.UnoProject {
	
	public partial class Card
	{
		public CardData cardData;
		protected Card(CardData pCardData = null)
		{
			cardData = pCardData;
		}

		// protected void SetupCardData(CardData.CardType pCardType)
		// {
		// 	cardData.cardType = pCardType;
		// }
	}
}
