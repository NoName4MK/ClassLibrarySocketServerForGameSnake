using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrarySocketServerForGameSnake
{
    public struct xy
    {
        public int x { get; set; }
        public int y { get; set; }
        public xy(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    class Player
    {
        //public Socket Socket { get; private set;}
        public int Id { get; private set; }
        public List<xy> ListPoint { get; set; }
        public int Time { get; set; }
        //public Player(Socket socket, int id, int x, int y, int linght)
        public Player(int id, List<xy> listPoint, int time)
        {
            //this.Socket = socket;
            this.Id = id;
            ListPoint = listPoint;
            Time = time;
        }
        public string GetListPoint()
        {
            string str = null;
            foreach (xy point in this.ListPoint)
            {
                str += String.Format(",x:{0},y:{1}", point.x, point.y);
            }
            return str;
        }

    }
}
