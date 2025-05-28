namespace IdfOperation.Idf.Commands.GroundForces.Forces.M109
{
    /// <summary>
    /// מחלקה המייצגת תותח M109 במצב הפעלה ידני
    /// </summary>
    internal class M109Manual : M109
    {
        /// <summary>
        /// יוצר תותח M109 חדש במצב הפעלה ידני
        /// </summary>
        /// <param name="name">שם התותח</param>
        /// <param name="ammunition">כמות תחמושת התחלתית (0-40)</param>
        /// <param name="fuel">כמות דלק התחלתית (0-40)</param>
        /// <param name="strikeLimit">מספר תקיפות מקסימלי במחזור (0-40)</param>
        public M109Manual(string name, int ammunition, double fuel, int strikeLimit)
            : base(name, ammunition, fuel, strikeLimit)
        {

        }

    }
}
