using System;
using Xamarin.Forms;

namespace FacturaApp
{
    public partial class MainPage : ContentPage
    {
        double MONTOFACTURA, DESCUENTO, MORA, NETOAPAGAR, TOTALAPAGAR;
        int DIAS;

        public MainPage()
        {
            InitializeComponent();
            Limpiar(this, new EventArgs());
        }

        private void Decision(object sender, EventArgs e)
        {
            Entradas();
            if  (DIAS <= 30)
            {
                MORA = TOTALAPAGAR = 0;
                DESCUENTO = MONTOFACTURA * 0.10;
                NETOAPAGAR = MONTOFACTURA - DESCUENTO;
            }
            else
            {
                DESCUENTO = NETOAPAGAR = 0;
                MORA = MONTOFACTURA * 0.05;
                TOTALAPAGAR = MONTOFACTURA + MORA;
            }
            Salida();
        }

        private void Entradas()
        {
            MONTOFACTURA = Convert.ToDouble(EMONTOFACTURA.Text);
            DIAS = Convert.ToInt32(EDIAS.Text);
        }

        private void Salida()
        {
            EDESCUENTO.Text = Convert.ToString(DESCUENTO);
            EMORA.Text = Convert.ToString(MORA);
            ENETOAPAGAR.Text = Convert.ToString(NETOAPAGAR);
            ETOTALAPAGAR.Text = Convert.ToString(TOTALAPAGAR);
        }

        private void Limpiar(object sender, EventArgs e)
        {
            MONTOFACTURA = DESCUENTO = MORA = NETOAPAGAR = TOTALAPAGAR = DIAS = 0;

            EMONTOFACTURA.Text = EDESCUENTO.Text = EMORA.Text = ENETOAPAGAR.Text = ETOTALAPAGAR.Text = EDIAS.Text = "0";
        }

        void Salir(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
    }
}
