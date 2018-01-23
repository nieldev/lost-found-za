using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LostAndFound.Framework.Enums.BaseClasses;

namespace LostAndFound.Framework.Enums.Enumerations
{
    public class CardType : Enumeration
    {
        public static CardType Amex = new CardType(1, "Amex");
        public static CardType Visa = new CardType(2, "Visa");
        public static CardType MasterCard = new CardType(3, "MasterCard");

        protected CardType() { }

        public CardType(int id, string name)
            : base(id, name)
        {
        }

        public static IEnumerable<CardType> List()
        {
            return new[] { Amex, Visa, MasterCard };
        }
        // Other util methods
    }
}
