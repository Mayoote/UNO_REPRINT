using Godot;
using System;

// Author : Maïtson PIERRE

namespace Maitson.PIERRE.UnoProject {
	
	public partial class CardData
	{
		[Flags]
		public enum CardType 
		{
			numberZero,
			numberOne,
			numberTwo,
			numberThree,
			numberFour,
			numberFive,
			numberSix,
			numberSeven,
			numberEight,
			numberNine,
			Reverse,
			Skip,
			Wild,
			WildDrawFour,
			DrawTwo,
		}

		public enum CardColor
		{
			Blue,
			Red,
			Green,
			Yellow,
		}
		
		public int playerId; 
		public bool canInvertTurnOrder;
		public bool canSkipTurn;
		public CardType cardType;
		public CardColor cardColor;
	}
}
