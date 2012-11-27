using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Mork
{
    public class GObj
    {
        public Texture2D tex;
        public string name;
        public Color col;

        public List<int> grass = new List<int>();

        public int under_surf = 10;
        public int under_under_surf = 22;

        public List<int> tree = new List<int>();
        public int tree_freq = 5;

        public GObj(Texture2D _tex, Color _col, string _name)
        {
            tex = _tex;
            name = _name;
            col = _col;
        }
    }
}