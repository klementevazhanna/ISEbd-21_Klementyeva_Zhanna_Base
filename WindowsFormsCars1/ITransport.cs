using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsCars1
{
    interface ITransport
    {
        void SetPosition(int x, int y, int width, int height);

        void MoveTransport(Direction direction);

        void DrawTransport(Graphics g);
    }
}
