using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poo.models
{
    enum Rate
    {
        NO_RATE = 0,
        ONE = 1,
        TWO = 2,
        THREE = 3,
        FOUR = 4,
        FIVE = 5,
    }

    internal class Review
    {
        public static int id;
        private string user;
        private Rate rate;
        private string text;

        public Review(string user, Rate rate, string text)
        {
            ++id;
            this.user = user;
            this.rate = rate;
            this.text = text;
        }

        public string User
        { get { return user; } set { user = value; } }

        public Rate Rate
        { get { return rate; } set { rate = value; } }

        public string Text
        { get { return text; } set { text = value; } }

        public override string ToString()
        {
            return $"Review by: {user}\nRating: {rate}\nText: {text}\n";
        }
    }
}