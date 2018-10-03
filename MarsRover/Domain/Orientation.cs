using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRover.Domain
{
    public enum Orientation
    {
      
        [DisplayText("N")]
        N = 1,
        [DisplayText("E")]
        E = 2,
        [DisplayText("S")]
        S = 3,
        [DisplayText("W")]
        W = 4
    }


    public class DisplayText : Attribute
    {

        public DisplayText(string Text)
        {
            this.text = Text;
        }


        private string text;


        public string Text
        {
            get { return text; }
            set { text = value; }
        }
    }
}
