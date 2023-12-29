using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine
{
    public class Coffeemachine
    {
        public int water;
        public int coffee;
        public int milk;
        public int chocolate;

        public Coffeemachine()
        {
            water = 1000;
            coffee = 500;
            milk = 500;
            chocolate = 500;
        }

        public void blackcoffeenotuse () {
            water += 300;
            coffee += 20;
        }  
        public bool makeBlackCoffee() {
            if (water >= 300 && coffee >= 20)
            {
                water = water - 300;
                coffee = coffee - 20;
                return true;
            }
            else { 
                return false;
            }
        }
        public void latenotuse()
        {
            water += 300;
            coffee += 20;
            milk += 10;
        }
        public bool makelate()
        {
            if (water >= 300 && coffee >= 20 && milk >=10)
            {
                
                water = water - 300;
                coffee = coffee - 20;
                milk = milk - 10;
                return true;
            }
            else
            {
                return false;
            }
        }
        public void mochanotuse()
        {
            water += 300;
            coffee += 20;
            chocolate += 10;
        }
        public bool makeMocha()
        {
            if (water >= 300 && coffee >= 20 && chocolate >= 10)
            {
                
                water = water - 300;
                coffee = coffee - 20;
                chocolate = chocolate - 10;
                return true;
            }
            else
            {
                return false;
            }
        }
        public void chocolatenotuse()
        {
            water += 300;
            chocolate += 20;
        }
        public bool makechocolate()
        {
            if (water >= 300 && chocolate >= 20)
            {
                
                water = water - 300;
                chocolate = chocolate - 20;
                return true;
            }
            else
            {
                return false;
            }
        }
        public void IteminToo()
        {
            string watercheck = water.ToString();
            string coffeecheck = coffee.ToString();
            string milkcheck = milk.ToString();
            string chocolatecheck = chocolate.ToString();
            string message = "วัตถุดิบที่เหลืออยู่ "+"น้ำ "+watercheck+" กรัม, "+"กาแฟ "+coffeecheck+" กรัม, "+"นม "+milkcheck+" กรัม, "+"ช็อคโกเล็ต "+chocolatecheck+" กรัม";
            string title = "สำหรับเจ้าพนักงงานเท่านั้น!";
            MessageBox.Show(message, title);
        }
    }
}
