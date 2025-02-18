using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Numerics;
using System.Data;
using System.Runtime.CompilerServices;

namespace test_pong
{
    internal class Ball
    {
        public  Vector2 Position {get;set;}
        public Vector2 Trajectoire { get; set; }
        public float Speed { get; set; }

        public Ball (Vector2 Position, Vector2 Trajectoire)
        {
            this.Position = Position;
            this.Trajectoire = Trajectoire;
            this.Speed = Speed;
        }

        public void UpdatePostion()
        {
            this.Position += Speed * Trajectoire;
        }
    }
}
