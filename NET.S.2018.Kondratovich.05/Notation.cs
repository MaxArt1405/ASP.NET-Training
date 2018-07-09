using System;
using System.Text;

namespace StringExtentionLibrary
{
    public class Notation
    {
        private int basis;

        /// <summary>
        /// Initializing a Notation with default value.
        /// </summary>
        public Notation(): this(10) { }
        /// <summary>
        /// Initializes Notation with base and alphabet.
        /// </summary>
        /// <param name="base">The base of notation</param>
        public Notation(int basis)
        {
            Basis = basis;
            Alphabet = StringCreation();
        }
        /// <summary>
        /// Getter for the base.
        /// </summary>
        public int Basis
        {
            get => basis;
            set => basis = value;
        }
        /// <summary>
        /// Getter for the alphabet of notation.
        /// </summary>
        public string Alphabet { get; private set; }
        /// <summary>
        /// The alphabet string creation on the basis of the base of the notation.
        /// </summary>
        /// <returns></returns>
        private string StringCreation()
        {
            int basis = Basis;
            StringBuilder sb = new StringBuilder(basis);
            int symbol = 'A';
            for (int i = 0; i < basis; i++)
            {
                if (i <= 9)
                {
                    sb.Append(i);
                }
                else
                {
                    sb.Append((char)symbol++);
                } 
            }
            return sb.ToString();
        }
    }
}