using Godot;
using System;
using System.Collections.Generic;
using System.Net;

// Author : Maïtson PIERRE

namespace Maitson.PIERRE.UnoProject
{

    public partial class Deck
    {
        private DeckData deckData;
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


        private void AddCard<T>(int pAmount, int pColorIndex = 0) where T : Card, new()
        {
            T lT;
            for (int i = 0; i < pAmount; i++)
            {
                lT = new T();
                lT.cardData.cardColor = (CardData.CardColor)pColorIndex;
                cards.Add(lT);
            }
        }
        private void CreateDeck(DeckData pDeckData)
        {
            Type lCardColorEnum = typeof(CardData.CardColor);
            CardData.CardColor[] lCardColors = (CardData.CardColor[])Enum.GetValues(lCardColorEnum);
            int lLength = lCardColors.Length;
            
            for (int i = 1; i < lLength; i++)
            {
                
                AddCard<NumberZero>(pDeckData.numberZeroAmount, i);
                AddCard<NumberOne>(pDeckData.numberOneAmount, i);
                AddCard<NumberTwo>(pDeckData.numberTwoAmount, i);
                AddCard<NumberThree>(pDeckData.numberThreeAmount, i);
                AddCard<NumberFour>(pDeckData.numberFourAmount, i);
                AddCard<NumberFive>(pDeckData.numberFiveAmount, i);
                AddCard<NumberSix>(pDeckData.numberSixAmount, i);
                AddCard<NumberSeven>(pDeckData.numberSevenAmount, i);
                AddCard<NumberEight>(pDeckData.numberEightAmount, i);
                AddCard<NumberNine>(pDeckData.numberNineAmount, i);
                AddCard<DrawTwo>(pDeckData.drawTwoAmount, i);
                AddCard<Reverse>(pDeckData.reverseAmount, i);
                AddCard<Skip>(pDeckData.skipAmount, i);
            }
                AddCard<Wild>(pDeckData.wildAmount);
                AddCard<WildPlusFour>(pDeckData.wildPlusFoursAmount);
        }
    }
}
