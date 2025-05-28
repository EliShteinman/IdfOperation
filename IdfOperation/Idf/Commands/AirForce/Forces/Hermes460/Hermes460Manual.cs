namespace IdfOperation.Idf.Commands.AirForce.Forces.Hermes460
{
    /// <summary>
    /// מחלקה המייצגת כטב"ם הרמס 460 במצב הפעלה ידני
    /// </summary>
    internal class Hermes460Manual : Hermes460
    {
        /// <summary>
        /// יוצר כטב"ם הרמס 460 חדש במצב הפעלה ידני
        /// </summary>
        /// <param name="name">שם הכטב"ם</param>
        /// <param name="ammunition">כמות תחמושת התחלתית (0-3)</param>
        /// <param name="fuel">כמות דלק התחלתית (0-3)</param>
        /// <param name="strikeLimit">מספר תקיפות מקסימלי במחזור (0-3)</param>
        public Hermes460Manual(string name, int ammunition, double fuel, int strikeLimit)
            : base(name, ammunition, fuel, strikeLimit)
        {

        }

    }
}
