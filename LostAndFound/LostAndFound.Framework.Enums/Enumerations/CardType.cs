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
        public static CardType Amex = new CardType(1, "Amex", "Amex", "Amex Card");
        public static CardType Visa = new CardType(2, "Visa", "Visa", "Visa Card");
        public static CardType MasterCard = new CardType(3, "MasterCard", "MasterCard", "Visa Card");

        public CardType(long id, string name, string displayName, string description)
            : base(id, name, displayName, description)
        {
       
        }

        public static IEnumerable<CardType> List()
        {
            return new[] { Amex, Visa, MasterCard };
        }


        // Other util methods
    }
}
