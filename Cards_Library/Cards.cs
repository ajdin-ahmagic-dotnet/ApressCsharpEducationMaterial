using System;
using System.Collections.Generic;
using System.Linq;
using System.Collections;

namespace Cards_Library
{
    /// <summary>
    /// Proširenje prijašnjeg primjera na kolekcije...
    /// </summary>
    public class Cards : CollectionBase
    {
        public void Add(Card newCard)
        {
            List.Add(newCard);
        }

        public void Remove(Card oldCard)
        {
            List.Add(oldCard);
        }

        public Card this[int cardIndex]
        {
            get
            {
                return (Card)List[cardIndex];
            }
            set
            {
            	List[cardIndex] = value;
            }
        }

        /// <summary>
        /// Ovo je jedna utility metoda za kopiranje Card instanci u drugu Cards
        /// instancu korištenu u Deck-Shuffle() metodi. Ova implementacija podrazumjeva
        /// da source-izvor i target-odredište kolekcije su iste veličine.
        /// </summary>
        public void CopyTo(Cards targetCards)
        {
            for(int index = 0; index < this.Count; index++)
            {
                targetCards[index] = this[index];
            }
        }

        /// <summary>
        /// Provjeri da li Cards kolekcija sadrži određenu kartu.
        /// Ova poziv Contains() metode od ArrayList kolekcije kojem možemo
        /// pristupiti preko InnerList osobine.
        /// </summary>
        public bool Contains(Card card)
        {
            return InnerList.Contains(card);
        }
    }
}
