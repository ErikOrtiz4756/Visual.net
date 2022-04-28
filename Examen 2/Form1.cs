namespace Examen_2;

public partial class Form1 : Form
{
    private Label? lblMoneda;
    private ComboBox? cmbMoneda;
    private Label? lblMonto;
    private TextBox? txtMonto;
    private Button? btnCalcular;
    private Button? btnBorrar;
    private Label? lblConversiones;
    private int num;
    private int num2;

    public Form1()
    {
        InitializeComponent();
        InicializarComponentes();
    }

    private void InicializarComponentes(){
        this.Size = new Size(320,320);

        lblMoneda = new Label();
        lblMoneda.Text = "Moneda";
        lblMoneda.AutoSize = true;
        lblMoneda.Location = new Point(10,10);

        cmbMoneda = new ComboBox();
        cmbMoneda.Items.Add("Selecciona Moneda");
        cmbMoneda.Items.Add("USD - Dólar Estadounidense");
        cmbMoneda.Items.Add("MXN - Peso Mexicano");
        cmbMoneda.Items.Add("CAD - Dólar Canadiense");
        cmbMoneda.Items.Add("EUR - Euro");
        cmbMoneda.Items.Add("JPY - Yen Japonés");
        cmbMoneda.Size = new Size(174, 30);
        cmbMoneda.SelectedIndex = 0;
        cmbMoneda.Location = new Point(10,25);

        lblMonto = new Label();
        lblMonto.Text = "Monto";
        lblMonto.AutoSize = true;
        lblMonto.Location = new Point(182,10);

        txtMonto = new TextBox();
        txtMonto.Size = new Size(100,30);
        txtMonto.Location = new Point(185,25);
        txtMonto.KeyPress += new KeyPressEventHandler(ValidarNum_Keypress);

        btnCalcular= new Button();
        btnCalcular.Text="Calcular";
        btnCalcular.Size = new Size(100,25);
        btnCalcular.Location= new Point(185,55);
        btnCalcular.Click += new EventHandler(btnCalcular_click);

        btnBorrar= new Button();
        btnBorrar.Text="Borrar";
        btnBorrar.Size = new Size(100,25);
        btnBorrar.Location= new Point(10,55);
        btnBorrar.Click += new EventHandler(btnBorrar_click);

        lblConversiones = new Label();
        lblConversiones.Text = "Conversiones";
        lblConversiones.AutoSize = true;
        lblConversiones.Location = new Point(10,100);

        this.Controls.Add(lblMoneda);
        this.Controls.Add(cmbMoneda);
        this.Controls.Add(lblMonto);
        this.Controls.Add(txtMonto);
        this.Controls.Add(btnCalcular);
        this.Controls.Add(btnBorrar);
        this.Controls.Add(lblConversiones);
    }

    private void btnCalcular_click(Object? sender, EventArgs e){
        num = 0;
        num2 = 0;
        Form2 frmMonedas = new Form2();
        if(cmbMoneda.SelectedIndex!=0){
            if(cmbMoneda.SelectedItem.ToString()=="USD - Dólar Estadounidense"){
                frmMonedas.checkedListBox1.Items.RemoveAt(0);
            }
            if(cmbMoneda.SelectedItem.ToString()=="MXN - Peso Mexicano"){
                frmMonedas.checkedListBox1.Items.RemoveAt(1);
            }
            if(cmbMoneda.SelectedItem.ToString()=="CAD - Dólar Canadiense"){
                frmMonedas.checkedListBox1.Items.RemoveAt(2);
            }
            if(cmbMoneda.SelectedItem.ToString()=="EUR - Euro"){
                frmMonedas.checkedListBox1.Items.RemoveAt(3);
            }
            if(cmbMoneda.SelectedItem.ToString()=="JPY - Yen Japonés"){
                frmMonedas.checkedListBox1.Items.RemoveAt(4);
            }
        
        }
        if(string.IsNullOrEmpty(txtMonto.Text)){
            MessageBox.Show("El campo Monto no puede estar vacio", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
        }else{
            if(frmMonedas.ShowDialog()==DialogResult.OK){
                if(cmbMoneda.SelectedIndex!=0){
                    if(cmbMoneda.SelectedItem.ToString()=="USD - Dólar Estadounidense"){
                        foreach(object itemChecked in frmMonedas.checkedListBox1.CheckedItems) {
                            Label lblAgergado = new Label();
                            lblAgergado.Text = itemChecked.ToString();
                            lblAgergado.AutoSize = true;
                            lblAgergado.Location = new Point(10,120+num);
                            num+=35;
                            this.Controls.Add(lblAgergado);

                            TextBox txtAgregado = new TextBox();
                            txtAgregado.Size = new Size(100,5);
                            txtAgregado.Location= new Point(180,120+num2);
                            num2+=35;
                            this.Controls.Add(txtAgregado);

                            if(cmbMoneda.SelectedItem.ToString()=="USD - Dólar Estadounidense"){
                                string calculo=itemChecked.ToString();
                                if(txtMonto.Text!=""){
                                    if(calculo=="MXN - Peso Mexicano"){
                                        int monto = Convert.ToInt32(txtMonto.Text);
                                        double res = monto * 21.3;
                                        txtAgregado.Text=("$"+res).ToString();
                                    }
                                    else if(calculo=="CAD - Dólar Canadiense"){
                                        int monto = Convert.ToInt32(txtMonto.Text);
                                        double res = monto * 1.28;
                                        txtAgregado.Text=("$"+res).ToString();
                                    }
                                    else if(calculo=="EUR - Euro"){
                                        int monto = Convert.ToInt32(txtMonto.Text);
                                        double res = monto * 0.89;
                                        txtAgregado.Text=("€"+res).ToString();
                                    }
                                    else if(calculo=="JPY - Yen Japonés"){
                                        int monto = Convert.ToInt32(txtMonto.Text);
                                        double res = monto * 113.05;
                                        txtAgregado.Text=("¥"+res).ToString();
                                    }
                                }
                            }
                        }           
                    }
                    if(cmbMoneda.SelectedItem.ToString()=="MXN - Peso Mexicano"){
                        foreach(object itemChecked in frmMonedas.checkedListBox1.CheckedItems) {
                            Label lblAgergado = new Label();
                            lblAgergado.Text = itemChecked.ToString();
                            lblAgergado.AutoSize = true;
                            lblAgergado.Location = new Point(10,120+num);
                            num+=35;
                            this.Controls.Add(lblAgergado);

                            TextBox txtAgregado = new TextBox();
                            txtAgregado.Size = new Size(100,5);
                            txtAgregado.Location= new Point(180,120+num2);
                            num2+=35;
                            this.Controls.Add(txtAgregado);

                            if(cmbMoneda.SelectedItem.ToString()=="MXN - Peso Mexicano"){
                                string calculo=itemChecked.ToString();
                                if(txtMonto.Text!=""){
                                    if(calculo=="USD - Dólar Estadounidense"){
                                        int monto = Convert.ToInt32(txtMonto.Text);
                                        double res = monto * 0.05;
                                        txtAgregado.Text=("$"+res).ToString();
                                    }
                                    else if(calculo=="CAD - Dólar Canadiense"){
                                        int monto = Convert.ToInt32(txtMonto.Text);
                                        double res = monto * 0.06;
                                        txtAgregado.Text=("$"+res).ToString();
                                    }
                                    else if(calculo=="EUR - Euro"){
                                        int monto = Convert.ToInt32(txtMonto.Text);
                                        double res = monto * 0.04;
                                        txtAgregado.Text=("€"+res).ToString();
                                    }
                                    else if(calculo=="JPY - Yen Japonés"){
                                        int monto = Convert.ToInt32(txtMonto.Text);
                                        double res = monto * 5.32;
                                        txtAgregado.Text=("¥"+res).ToString();
                                    }
                                }
                            }
                        }                  
                    }
                    if(cmbMoneda.SelectedItem.ToString()=="CAD - Dólar Canadiense"){
                        foreach(object itemChecked in frmMonedas.checkedListBox1.CheckedItems) {
                            Label lblAgergado = new Label();
                            lblAgergado.Text = itemChecked.ToString();
                            lblAgergado.AutoSize = true;
                            lblAgergado.Location = new Point(10,120+num);
                            num+=35;
                            this.Controls.Add(lblAgergado);

                            TextBox txtAgregado = new TextBox();
                            txtAgregado.Size = new Size(100,5);
                            txtAgregado.Location= new Point(180,120+num2);
                            num2+=35;
                            this.Controls.Add(txtAgregado);

                            if(cmbMoneda.SelectedItem.ToString()=="CAD - Dólar Canadiense"){
                                string calculo=itemChecked.ToString();
                                if(txtMonto.Text!=""){
                                    if(calculo=="USD - Dólar Estadounidense"){
                                        int monto = Convert.ToInt32(txtMonto.Text);
                                        double res = monto * 0.78;
                                        txtAgregado.Text=("$"+res).ToString();
                                    }
                                    else if(calculo=="MXN - Peso Mexicano"){
                                        int monto = Convert.ToInt32(txtMonto.Text);
                                        double res = monto * 16.55;
                                        txtAgregado.Text=("$"+res).ToString();
                                    }
                                    else if(calculo=="EUR - Euro"){
                                        int monto = Convert.ToInt32(txtMonto.Text);
                                        double res = monto * 0.69;
                                        txtAgregado.Text=("€"+res).ToString();
                                    }
                                    else if(calculo=="JPY - Yen Japonés"){
                                        int monto = Convert.ToInt32(txtMonto.Text);
                                        double res = monto * 88.12;
                                        txtAgregado.Text=("¥"+res).ToString();
                                    }
                                }
                            }
                        }                  
                    }
                    if(cmbMoneda.SelectedItem.ToString()=="EUR - Euro"){
                        foreach(object itemChecked in frmMonedas.checkedListBox1.CheckedItems) {
                            Label lblAgergado = new Label();
                            lblAgergado.Text = itemChecked.ToString();
                            lblAgergado.AutoSize = true;
                            lblAgergado.Location = new Point(10,120+num);
                            num+=35;
                            this.Controls.Add(lblAgergado);

                            TextBox txtAgregado = new TextBox();
                            txtAgregado.Size = new Size(100,5);
                            txtAgregado.Location= new Point(180,120+num2);
                            num2+=35;
                            this.Controls.Add(txtAgregado);

                            if(cmbMoneda.SelectedItem.ToString()=="EUR - Euro"){
                                string calculo=itemChecked.ToString();
                                if(txtMonto.Text!=""){
                                    if(calculo=="USD - Dólar Estadounidense"){
                                        int monto = Convert.ToInt32(txtMonto.Text);
                                        double res = monto * 1.13;
                                        txtAgregado.Text=("$"+res).ToString();
                                    }
                                    else if(calculo=="MXN - Peso Mexicano"){
                                        int monto = Convert.ToInt32(txtMonto.Text);
                                        double res = monto * 23.96;
                                        txtAgregado.Text=("$"+res).ToString();
                                    }
                                    else if(calculo=="CAD - Dólar Canadiense"){
                                        int monto = Convert.ToInt32(txtMonto.Text);
                                        double res = monto * 1.45;
                                        txtAgregado.Text=("$"+res).ToString();
                                    }
                                    else if(calculo=="JPY - Yen Japonés"){
                                        int monto = Convert.ToInt32(txtMonto.Text);
                                        double res = monto * 127.56;
                                        txtAgregado.Text=("¥"+res).ToString();
                                    }
                                }
                            }
                        }                  
                    }
                    if(cmbMoneda.SelectedItem.ToString()=="JPY - Yen Japonés"){
                        foreach(object itemChecked in frmMonedas.checkedListBox1.CheckedItems) {
                            Label lblAgergado = new Label();
                            lblAgergado.Text = itemChecked.ToString();
                            lblAgergado.AutoSize = true;
                            lblAgergado.Location = new Point(10,120+num);
                            num+=35;
                            this.Controls.Add(lblAgergado);

                            TextBox txtAgregado = new TextBox();
                            txtAgregado.Size = new Size(100,5);
                            txtAgregado.Location= new Point(180,120+num2);
                            num2+=35;
                            this.Controls.Add(txtAgregado);

                            if(cmbMoneda.SelectedItem.ToString()=="JPY - Yen Japonés"){
                                string calculo=itemChecked.ToString();
                                if(txtMonto.Text!=""){
                                    if(calculo=="USD - Dólar Estadounidense"){
                                        int monto = Convert.ToInt32(txtMonto.Text);
                                        double res = monto * 0.0088;
                                        txtAgregado.Text=("$"+res).ToString();
                                    }
                                    else if(calculo=="MXN - Peso Mexicano"){
                                        int monto = Convert.ToInt32(txtMonto.Text);
                                        double res = monto * 0.1878;
                                        txtAgregado.Text=("$"+res).ToString();
                                    }
                                    else if(calculo=="CAD - Dólar Canadiense"){
                                        int monto = Convert.ToInt32(txtMonto.Text);
                                        double res = monto * 0.0113;
                                        txtAgregado.Text=("$"+res).ToString();
                                    }
                                    else if(calculo=="EUR - Euro"){
                                        int monto = Convert.ToInt32(txtMonto.Text);
                                        double res = monto * 0.0078;
                                        txtAgregado.Text=("€"+res).ToString();
                                    }
                                }
                            }
                        }                  
                    }
                }
            }
        }
    }

    private void ValidarNum_Keypress(Object? sender, KeyPressEventArgs e){
        if((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255)){
            MessageBox.Show("Solo se aceptan numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            e.Handled = true;
            return;
        }
    }
    private void btnBorrar_click(Object? sender, EventArgs e){
        Application.Restart();
    }
}

