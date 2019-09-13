using Laboratorio_4_OOP_201902.Cards;
using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_4_OOP_201902
{
    public class Deck
    {

        private List<Card> cards;

        public Deck()
        {
        
        }

        public List<Card> Cards { get => cards; set => cards = value; }

        public void AddCard(Card card)
        {
            cards.add(card);
            //Agregue la carta card a la lista cards
            throw new NotImplementedException();

            return;
        }
        public void DestroyCard(int cardId)
        {
            cards.RemoveAt(cardId);
            /* Debe eliminar la carta segun el parametro cardId. Para esto
                1- Utilice el metodo RemoveAt de las listas para eliminar la carta en cards
            */
            throw new NotImplementedException();

            return;
        }
        public void Shuffle()
        {
            Random nrorandom = new Random();
            int revolver = nrorandom.Next(0, 100);


            List<Card> randomdeck = new List<Card>();

            int n = 0;

            while ( n < revolver)
            {
                int cardid = nrorandom.Next(0, cards.Count);

                randomdeck.add(cards[carid]);


            }
            //Reordenar el mazo de manera aleatoria (barajar).
            throw new NotImplementedException();

            return;
        }
    }
}
