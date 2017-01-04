using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApplication4
{
    public class President
    {
        private int _mood;

        public event Action<string> PressingButton;

        public string Name
        {
            get;set;
        }

        public int Tolerance
        {
            get; set;
        }

        public void ReceiveMessage(string msg)
        {
            if (Regex.IsMatch(msg, "(small|short)"))
            {
                _mood--;
                if (Math.Abs(_mood) >= Tolerance)
                {
                    //PressingButton?.Invoke();
                    if (PressingButton != null)
                    {
                        PressingButton.Invoke($"You have {msg}");
                    }
                }
            }

             
        }
    }
}