using System.Windows.Forms;

namespace CoffeeMachine
{
    public partial class Form1 : Form
    {

        Coffeemachine coffeemachine;
        public Form1()
        {
            InitializeComponent();
            coffeemachine = new Coffeemachine();
            showitem.Visible = false;
        }
        public void button2_Click(object sender, EventArgs e)
        {
            bool canMake = coffeemachine.makeBlackCoffee();
            if (canMake)
            {
                BlackCoffeeWindow f2 = new BlackCoffeeWindow();
                f2.ShowDialog();
                if (f2.OKButtonClicked == true)
                {
                    showitem.Image = global::CoffeeMachine.Properties.Resources.blackcoffee;
                    showitem.Visible = true;
                }
                else
                {
                    coffeemachine.blackcoffeenotuse();
                }
            }
            else
            {
                string message = "ขณะนี้ตู้มีวัตถุดิบไม่เพียงพอ กรุณารอการเติมวัตถุดิบ หรือ ติดต่อพนักงานที่เบอร์ XXXXXXXXXX";
                string title = "ขออภัยขณะนี้สินค้าของเราหมด!";
                MessageBox.Show(message, title);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bool canMake = coffeemachine.makechocolate();
            if (canMake)
            {
                ChocolateWindow f2 = new ChocolateWindow();
                f2.ShowDialog();
                if (f2.OKButtonClicked == true)
                {
                    showitem.Image = global::CoffeeMachine.Properties.Resources.chocolate;
                    showitem.Visible = true;
                }
                else
                {
                    coffeemachine.chocolatenotuse();
                }
            }
            else
            {
                string message = "ขณะนี้ตู้มีวัตถุดิบไม่เพียงพอ กรุณารอการเติมวัตถุดิบ หรือ ติดต่อพนักงานที่เบอร์ XXXXXXXXXX";
                string title = "ขออภัยขณะนี้สินค้าของเราหมด!";
                MessageBox.Show(message, title);
            }
        }

        private void BlackCoffeeWindow_Click(object sender, EventArgs e)
        {
            bool canMake = coffeemachine.makelate();
            if (canMake)
            {
                LateWindow f2 = new LateWindow();
                f2.ShowDialog();
                if (f2.OKButtonClicked == true)
                {
                    showitem.Image = global::CoffeeMachine.Properties.Resources.late;
                    showitem.Visible = true;
                }
                else
                {
                    coffeemachine.latenotuse();
                }
            }
            else
            {
                string message = "ขณะนี้ตู้มีวัตถุดิบไม่เพียงพอ กรุณารอการเติมวัตถุดิบ หรือ ติดต่อพนักงานที่เบอร์ XXXXXXXXXX";
                string title = "ขออภัยขณะนี้สินค้าของเราหมด!";
                MessageBox.Show(message, title);
            }
        }

        public void showitem_Click(object sender, EventArgs e)
        {
           
        }

        private void checkadmin_Click(object sender, EventArgs e)
        {
            coffeemachine.IteminToo();
        }

        private void mocha_Click(object sender, EventArgs e)
        {
            {
                bool canMake = coffeemachine.makeMocha();
                if (canMake)
                {
                    MochaWindow f2 = new MochaWindow();
                    f2.ShowDialog();
                    if (f2.OKButtonClicked == true)
                    {
                        showitem.Image = global::CoffeeMachine.Properties.Resources.mocha;
                        showitem.Visible = true;
                    }
                    else
                    {
                        coffeemachine.mochanotuse();
                    }
                }
                else
                {
                    string message = "ขณะนี้ตู้มีวัตถุดิบไม่เพียงพอ กรุณารอการเติมวัตถุดิบ หรือ ติดต่อพนักงานที่เบอร์ XXXXXXXXXX";
                    string title = "ขออภัยขณะนี้สินค้าของเราหมด!";
                    MessageBox.Show(message, title);
                }
            }
        }
    }
}
