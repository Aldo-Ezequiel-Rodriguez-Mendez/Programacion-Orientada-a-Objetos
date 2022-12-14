namespace Ejercicio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (radRueda.Checked)
                {
                    Circunferencia rueda = new Circunferencia(double.Parse(txtRadio.Text));
                    if (radCalcularArea.Checked)
                    {
                        MessageBox.Show("El area de la rueda es " + rueda.CalcularArea().ToString(), "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("El perimetro de la rueda es " + rueda.CalcularPerimetro().ToString(), "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
                else
                {
                    Circunferencia moneda = new Circunferencia(double.Parse(txtRadio.Text));
                    if (radCalcularArea.Checked)
                    {
                        MessageBox.Show("El area de la moneda es " + moneda.CalcularArea().ToString(), "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("El perimetro de la moneda es " + moneda.CalcularPerimetro().ToString(), "INFORMACIÓN", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ha ocurrido el siguiente error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}