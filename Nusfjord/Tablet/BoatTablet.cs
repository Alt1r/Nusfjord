using System.Collections.Generic;
using System.Linq;
using Nusfjord.BuildableObject.Boat;

namespace Nusfjord.Tablet
{
    /// <summary>
    /// Планшет лодок
    /// </summary>
    public class BoatTablet
    {
        private const int DefaultCatchSacle = 3;
        private const int MaxBoatsLength = 16;
        private const string AddBoatErrorText = "Нельзя добавить лодку! Выход за предел длины планшета!";
        private const string AddBoatSuccessText = "Лодка успешно добавлена.";

        private List<IBoat> _boatList = new List<IBoat>();
        private int _boatLength = 0;
        
        public int CatchScalse => CalculateCatchScale();  

        public string AddBoat(IBoat boat)
        {
            if (_boatLength + boat.Length > MaxBoatsLength) return CreateAddBoatText(AddBoatErrorText);
            _boatLength += boat.Length;
            return CreateAddBoatText(AddBoatSuccessText);
        }

        #region private

        private string CreateAddBoatText(string mainText)
        {
            return mainText + $" Лодок в наличии: {_boatList.Count}, значение улова: {CatchScalse}, длина лодок: {_boatLength}";
        }

        private int CalculateCatchScale()
        {
            var boatLength = _boatList.Sum(x => x.Length);
            if (boatLength <= 2) return 3;
            if (boatLength <= 3) return 5;
            if (boatLength <= 5) return 6;
            if (boatLength <= 6) return 7;
            if (boatLength <= 8) return 8;
            if (boatLength <= 9) return 9;
            if (boatLength <= 11) return 10;
            if (boatLength <= 13) return 11;
            return 12;
        }

        #endregion
        
    }
}