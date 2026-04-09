namespace BurgerKiosk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            rdoHamburger.Checked = false;
            rdoBulgogiBurger.Checked = false;
            rdoChickenBurger.Checked = false;
            lblError.Visible = false;
            this.Refresh();
        }

        int totalCost = 0;

        private void btnOrder_Click(object sender, EventArgs e)
        {
            lstOrder.Items.Clear();

            totalCost = 0;

            if (!rdoHamburger.Checked && !rdoBulgogiBurger.Checked && !rdoChickenBurger.Checked)
            {
                lblError.Visible = true;
                return;
            }
            else
            {
                lblError.Visible = false;
            }

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

            lblTotal.Text = $"총 금액 : {totalCost:N0}원";

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

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnOrder_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
                return;
            }

            Control focused = this.ActiveControl;
            if (focused is ContainerControl c && c.ActiveControl != null)
                focused = c.ActiveControl;

            var menu = new Control[] { rdoHamburger, rdoBulgogiBurger, rdoChickenBurger };
            var options = new Control[] { chkFries, chkCola, chkCheese, chkSauce };

            int mi = Array.IndexOf(menu, focused);
            if (mi >= 0)
            {
                if (e.KeyCode == Keys.Down) { menu[Math.Min(mi + 1, menu.Length - 1)].Focus(); e.Handled = true; e.SuppressKeyPress = true; }
                else if (e.KeyCode == Keys.Up) { menu[Math.Max(mi - 1, 0)].Focus(); e.Handled = true; e.SuppressKeyPress = true; }
                else if (e.KeyCode == Keys.Space) { ((RadioButton)focused).Checked = true; e.Handled = true; e.SuppressKeyPress = true; }
                return;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Tab || keyData == (Keys.Tab | Keys.Shift))
            {
                Control focused = this.ActiveControl;
                if (focused is ContainerControl c && c.ActiveControl != null)
                    focused = c.ActiveControl;

                var menu = new Control[] { rdoHamburger, rdoBulgogiBurger, rdoChickenBurger };
                var options = new Control[] { chkFries, chkCola, chkCheese, chkSauce };

                if (Array.IndexOf(menu, focused) >= 0)
                    options[0].Focus();
                else
                    menu[0].Focus();

                return true; // handled
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
