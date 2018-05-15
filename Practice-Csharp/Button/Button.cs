using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Vector2;

namespace Button
{
    public class Button
    {
        public delegate void ButtonIsClicked();

        public ButtonIsClicked OnClick;

        public Vector2.Vector2 position;

        public int _scale;

        public Button(Vector2.Vector2 pos, int scale)
        {
            position = pos;
            _scale = scale;
        }


    }
}
