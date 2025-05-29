using IdfOperation.Idf.Constants;

namespace IdfOperation.Idf.Commands.AirForce.Forces.F16
{
    /// <summary>
    /// מחלקה המייצגת מטוס F16 במצב ייצור ידני
    /// </summary>
    internal class F16Manual : F16
    {
        /// <summary>
        /// יוצר מטוס F16 חדש במצב ייצור ידני
        /// </summary>
        /// <param name="name">שם המטוס</param>
        /// <param name="ammunition">כמות תחמושת התחלתית (0-8)</param>
        /// <param name="fuel">כמות דלק התחלתית (0-8)</param>
        /// <param name="strikeLimit">מספר תקיפות מקסימלי במחזור (0-8)</param>
        /// <param name="pilot">טייס המטוס</param>
        public F16Manual(string name, int ammunition, double fuel, int strikeLimit, IdfSoldier pilot)
            : base(name, ammunition, fuel, strikeLimit, pilot)
        {

        }

    }
}
