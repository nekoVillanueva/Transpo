using System;

namespace Transportation
{
    public class Transpo
    {
        public string GetMake { get; set; }
        public string GetModel { get; set; }
        public string GetYear { get; set; }
        public string GetNumWheels { get; set; }
        public string GetColor { get; set; }
        public string GetEngineSize { get; set; }
       

        public int GetMph(int value)
        {
            return value;
        }
        public int GetMpg(int value1, int value2)
        {
            int mpg = value1 * value2;
            return mpg;
        }

        public string GetWear(int miles, int temp, int tread)
        {
            string condition = " ";
            if (temp!=0)

            {
                int calcOne = (miles*4) / temp;
                double calcTwo = tread * .5;
                if(calcOne<calcTwo)
                {
                    condition= "unsafe";
                }
                else
                {
                    condition = "safe";
                }
                
            }
            else
            {
                condition= "Invalid Entry";
            }
            return condition;
        }
    }
}