namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int totalCost = 0;

        private void btnOrder_Click(object sender, EventArgs e)
        {
            lstOrder.Items.Clear();

            totalCost = 0;

            if (rdoHamburger.Checked)
            {
                totalCost += 5000;
                lstOrder.Items.Add("햄버거 5,000원");
            }
            else if (rdoBulgogiBurger.Checked)
            {
                totalCost += 4000;
                lstOrder.Items.Add("불고기버거 4,000원");
            }
            else if (rdoChickenBurger.Checked)
            {
                totalCost += 3000;
                lstOrder.Items.Add("치킨버거 3,000원");
            }

            if (chkFries.Checked)
            {
                totalCost += 3500;
                lstOrder.Items.Add("감자튀김 3,500원");
            }

            if (chkCola.Checked)
            {
                totalCost += 2500;
                lstOrder.Items.Add("콜라 2,500원");
            }

            if (chkCheese.Checked)
            {
                totalCost += 1500;
                lstOrder.Items.Add("치즈 1,500원");
            }

            if (chkSauce.Checked)
            {
                totalCost += 500;
                lstOrder.Items.Add("소스 500원");
            }

            lblTotal.Text = $"총 금액 : {totalCost}원";

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            rdoHamburger.Checked = false;
            rdoBulgogiBurger.Checked = false;
            rdoChickenBurger.Checked = false;
            chkFries.Checked = false;
            chkCola.Checked = false;
            chkCheese.Checked = false;
            chkSauce.Checked = false;
            lblTotal.Text = "총 금액 : 0원";
            lstOrder.Items.Clear();
        }
    }
}
