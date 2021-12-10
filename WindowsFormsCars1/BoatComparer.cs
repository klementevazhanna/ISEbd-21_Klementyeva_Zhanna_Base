using System.Collections.Generic;

namespace WindowsFormsCars1
{
    public class BoatComparer : IComparer<ITransport>
    {
        public int Compare(ITransport x, ITransport y)
        {
            if (x.GetType().Name != y.GetType().Name)
            {
                return x.GetType().FullName.CompareTo(y.GetType().FullName);
            }
            if (x.GetType() == y.GetType() && x is Cater)
            {
                return ComparerCater((Cater)x, (Cater)y);
            }
            if (x.GetType() == y.GetType() && x is BaseBoat)
            {
                return ComparerBoat((BaseBoat)x, (BaseBoat)y);
            }
            return 0;
        }

        private int ComparerBoat(BaseBoat x, BaseBoat y)
        {
            if (x.MaxSpeed != y.MaxSpeed)
            {
                return x.MaxSpeed.CompareTo(y.MaxSpeed);
            }
            if (x.Weight != y.Weight)
            {
                return x.Weight.CompareTo(y.Weight);
            }
            if (x.MainColor != y.MainColor)
            {
                return x.MainColor.Name.CompareTo(y.MainColor.Name);
            }
            return 0;
        }

        private int ComparerCater(Cater x, Cater y)
        {
            var res = ComparerBoat(x, y);
            if (res != 0)
            {
                return res;
            }
            if (x.DopColor != y.DopColor)
            {
                return x.DopColor.Name.CompareTo(y.DopColor.Name);
            }
            if (x.Motor != y.Motor)
            {
                return x.Motor.CompareTo(y.Motor);
            }
            if (x.Square != y.Square)
            {
                return x.Square.CompareTo(y.Square);
            }
            return 0;
        }
    }
}
