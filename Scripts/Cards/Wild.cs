using Godot;
using System;

// Author : Maïtson PIERRE

namespace Maitson.PIERRE.UnoProject {
	
	public partial class Wild : Card
	{
		public Wild()
		{
			cardData.cardType = CardData.CardType.Wild;
		}
	}
}
