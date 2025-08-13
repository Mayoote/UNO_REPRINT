using Godot;
using System;

// Author : Maïtson PIERRE

namespace Maitson.PIERRE.UnoProject {
	
	public partial class Reverse : Card
	{
		public Reverse()
		{
			cardData.cardType = CardData.CardType.Reverse;
			cardData.canInvertTurnOrder = true;
		}
	}
}
