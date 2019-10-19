using Laboratorio_7_OOP_201902.Cards;
using Laboratorio_7_OOP_201902.Enums;
using Laboratorio_7_OOP_201902.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Laboratorio_7_OOP_201902
{
    [Serializable]
    public class Deck : ICharacteristics
    {

        private List<Card> cards;

        public Deck()
        {
        
        }

        public List<Card> Cards { get => cards; set => cards = value; }

        public void AddCard(Card card)
        {
            Cards.Add(card);
        }
        public void DestroyCard(int cardId)
        {
            cards.RemoveAt(cardId);
        }

        public List<string> GetCharacteristics()
        {
            List<string> granLista = new List<string>();
            List<Card> totalCards = (from card in cards
                                     select card).ToList();
            string TotalCards = Convert.ToString(Cards.Count());
            granLista.Add(TotalCards);

            List<Card> meleeCards = (from card in cards
                                       where card.Type == EnumType.melee
                                       select card).ToList();
            string MeleeCards = Convert.ToString(Cards.Count());
            granLista.Add(MeleeCards);

            List<Card> rangeCards = (from card in cards
                                       where card.Type == EnumType.range
                                       select card).ToList();
            string RangeCards = Convert.ToString(Cards.Count());
            granLista.Add(RangeCards);

            List<Card> longRangeCards = (from card in cards
                                       where card.Type == EnumType.longRange
                                       select card).ToList();
            string LongRangeCards = Convert.ToString(Cards.Count());
            granLista.Add(LongRangeCards);

            List<Card> buffCards = (from card in cards
                                         where card.Type == EnumType.buff
                                         select card).ToList();
            string BuffCards = Convert.ToString(Cards.Count());
            granLista.Add(BuffCards);

            List<Card> weatherCards = (from card in cards
                                         where card.Type == EnumType.weather
                                         select card).ToList();
            string WeatherCards = Convert.ToString(Cards.Count());
            granLista.Add(WeatherCards);

            int meleeAP = 0;
            foreach (CombatCard card in meleeCards)
            {
                meleeAP += card.AttackPoints;
            }
            string MeleeAP = Convert.ToString(meleeAP);
            granLista.Add(MeleeAP);

            int rangeAP = 0;
            foreach (CombatCard card in meleeCards)
            {
                rangeAP += card.AttackPoints;
            }
            string RangeAP = Convert.ToString(rangeAP);
            granLista.Add(RangeAP);

            int longRangeAP = 0;
            foreach (CombatCard card in meleeCards)
            {
                longRangeAP += card.AttackPoints;
            }
            string LongRangeAP = Convert.ToString(longRangeAP);
            granLista.Add(LongRangeAP);

            int totalAP = meleeAP + rangeAP + longRangeAP;
            string TotalAP = Convert.ToString(totalAP);
            granLista.Add(TotalAP);

            return granLista;
            
            
        }

        public void Shuffle()
        {
            Random random = new Random();
            int n = cards.Count;
            while (n > 1)
            {
                n--;
                int k = random.Next(n + 1);
                Card value = cards[k];
                cards[k] = cards[n];
                cards[n] = value;
            }
        }

    }
}
