using System;

namespace DecimalConverter
{
    /// <summary>
    /// Class for desribing and choosing alphabet for recieved notation
    /// </summary>
    public class Notation
    {
        /// <summary>
        /// The alpabet of all systems from 2 to 16
        /// </summary>
        private string AlphabetOfTypes = "0123456789ABCDEF";
        /// <summary>
        /// Choosing alphabet for recieved scale
        /// </summary>
        public string Alphabet => AlphabetOfTypes.Substring(0, Scale);
        /// <summary>
        /// 
        /// </summary>
        /// <param name="scale"></param>
        public Notation(int scale) => Scale = scale;
        /// <summary>
        /// Getter for scale
        /// </summary>
        public int Scale { get; }
    }
}
