namespace TDMPW_412_2P_EX;

public partial class Ordenar : ContentPage
{
    int numBebidas = 1;
    double precio = 0;
	public Ordenar()
	{
		InitializeComponent();
	}

    private void btnMenos_Clicked(object sender, EventArgs e)
    {
        if (numBebidas > 1)
        {
            numBebidas--;
        }
        txtNumeroBebidas.Text = numBebidas.ToString();
        calcularTotal();
    }

    private void btnMas_Clicked(object sender, EventArgs e)
    {
        numBebidas++;
        txtNumeroBebidas.Text = numBebidas.ToString();
        calcularTotal();
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        if (sender is ImageButton)
        {
            var btn = (ImageButton)sender;
            if(btn == this.btnLatte)
            {
                this.imgOrdenar.Source = "latte.png";
                this.txtNombre.Text = "Cafe latte";
                this.txtTamano.Text = "Mediano(14oz - 414ml)";
                this.txtCalorias.Text = "140 calorias";
                this.txtLeche.Text = "Leche Entera/Deslactosada/Ligth";
                this.txtCosto.Text = "$76.88";
                this.txtTotal.Text = $"Total..........................................$76.88";
                numBebidas = 1;
                txtNumeroBebidas.Text = numBebidas.ToString();
            }
            else
            {
                if(btn == this.btnChocolate)
                {
                    this.imgOrdenar.Source = "chocolate.png";
                    this.txtNombre.Text = "Chocolate Mexicano";
                    this.txtTamano.Text = "Grande(18oz - 532ml)";
                    this.txtCalorias.Text = "308 calorias";
                    this.txtLeche.Text = "Leche Entera/Deslactosada/Ligth";
                    this.txtCosto.Text = "$76.09";
                    this.txtTotal.Text = $"Total..........................................$76.09";
                    numBebidas = 1;
                    txtNumeroBebidas.Text = numBebidas.ToString();
                }
                else
                {
                    if(btn == this.btnCappuccino)
                    {
                        this.imgOrdenar.Source = "cappuccino.png";
                        this.txtNombre.Text = "Cafe cappuccino";
                        this.txtTamano.Text = "Grande(16oz - 437ml)";
                        this.txtCalorias.Text = "190 calorias";
                        this.txtLeche.Text = "Leche Entera/Deslactosada/Ligth";
                        this.txtCosto.Text = "$44.00";
                        this.txtTotal.Text = $"Total..........................................$44.00";
                        numBebidas = 1;
                        txtNumeroBebidas.Text = numBebidas.ToString();
                    }
                }
            }
        }
    }

    private void calcularTotal()
    {
        precio = double.Parse(this.txtCosto.Text.Replace("$", ""));
        var total = numBebidas * precio;
        this.txtTotal.Text = $"Total..........................................{total:C}";
    }
}