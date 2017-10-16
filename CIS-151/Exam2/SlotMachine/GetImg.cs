using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlotMachine
{
    class GetImg
    {
        private static int randNum;

        /// <summary>
        /// Class constructor
        /// </summary>
        public GetImg(int randNum)
        {
            this.RandNum = randNum;
        }
        public static string ImageLoc()
        {
            string[] image = { "bar.png", "bell.png", "bitcoin.png", "cherry.png", "clover.png",
                        "diamond.png", "horseshoe.png", "seven.png", "spade.png", "yinyang.png"};
            
            string imgLoc = image[randNum];
            return imgLoc;
        }

        public static int ImageNum()
        {
            int[] label = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            return label[randNum];
        }

        public override string ToString()
        {
            return "../../Resources/" + ImageLoc();
        }

        public int RandNum
        {
            get { return randNum; }
            set { randNum = value; }
        }
    }
}
