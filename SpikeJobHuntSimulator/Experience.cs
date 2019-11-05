using System;
namespace SpikeJobHuntSimulator
{
    class Experience
    {
        private string selection;

        public Experience(string aSelection)
        {
            Selection = aSelection; //calls the setter written below when using Selection instead of selection as the key
        }

        public string Selection
        {
            get { return selection; }
            set
            {
                if (value == "a" || value == "b" || value == "c")
                {
                    selection = value;
                }
                else
                {
                    selection = "invalid";
                }
            }
        }
    }
}