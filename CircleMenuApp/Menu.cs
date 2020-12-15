using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CircleMenuApp
{
    public class Menu
    {
        public void Add(string item)
        {
            if (items.Count == 0)
            {
                indexCurrentSelected = 0;
            }

            items.Add(item);
        }

        public void Next()
        {
            if (items.Count == 0)
            {
                return;
            }

            indexCurrentSelected++;
            if (indexCurrentSelected >= items.Count)
            {
                indexCurrentSelected = 0;
            }
        }

        public void Previous()
        {
            if (items.Count == 0)
            {
                return;
            }

            indexCurrentSelected--;
            if (indexCurrentSelected < 0)
            {
                indexCurrentSelected = items.Count - 1;
            }
        }

        public string GetSelected()
        {
            if (items.Count == 0)
            {
                return "";
            }

            return (string)items[indexCurrentSelected].;
        }

        public override string ToString()
        {
            if (items.Count == 0)
            {
                return "The menu is empty";
            }

            string output = "";
            for (int i = 0; i < items.Count; i++)
            {
                if (i == indexCurrentSelected)
                {
                    output += $"=> {items[i]}\n";
                }
                else
                {
                    output += $"   {items[i]}\n";
                }
            }
            return output;
        }

        // Dynamic array (class)
        private ArrayList items = new ArrayList();
        private int indexCurrentSelected = -1;
    }
}
