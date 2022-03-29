namespace Tarea3;

public partial class Form1 : Form
{
    private Label? lblFigura;
    private ComboBox? cmbFiguras;
    private Label? lblCalculo;
    private ComboBox? cmbCalculos;
    private Label? lblAltura;
    private TextBox? txtAltura;
    private Label? lblBase;
    private TextBox? txtBase;
    private Label? lblCC;
    private TextBox? txtCC;
    private Label? lblResultado;
    private TextBox? txtResultado;
    private Button? btnCalcular;
    public Form1()
    {
        InitializeComponent();
        InicializarComponentes();
    }

    private void InicializarComponentes()
    {
        // Tamaño de la ventana
        this.Size = new Size(300,350);

        //Etiqueta Figura
        lblFigura= new Label();
        lblFigura.Text="Figura";
        lblFigura.AutoSize=true;
        lblFigura.Location= new Point(10,10);

        //ComboBox Figuras
        cmbFiguras = new ComboBox();
        cmbFiguras.Items.Add("Selecciona figura");
        cmbFiguras.Items.Add("Cuadrado");
        cmbFiguras.Items.Add("Triangulo");
        cmbFiguras.Items.Add("Rectangulo");
        cmbFiguras.SelectedIndex=0;
        cmbFiguras.Location= new Point(10,40);
        cmbFiguras.SelectedValueChanged+=new EventHandler(cmb_ValueChanged);


        //Etiqueta Calculo
        lblCalculo= new Label();
        lblCalculo.Text="Cálculo";
        lblCalculo.AutoSize=true;
        lblCalculo.Location= new Point(150,10);

        //ComboBox Calculos
        cmbCalculos = new ComboBox();
        cmbCalculos.Items.Add("Selecciona calculo");
        cmbCalculos.Items.Add("Périmetro");
        cmbCalculos.Items.Add("Área");
        cmbCalculos.SelectedIndex=0;
        cmbCalculos.Location= new Point(150,40);
        cmbCalculos.SelectedValueChanged+=new EventHandler(cmb_ValueChanged);

        //Etiqueta Altura
        lblAltura= new Label();
        lblAltura.Text="Altura";
        lblAltura.AutoSize=true;
        lblAltura.Location= new Point(10,80);
        lblAltura.Visible=false;

        //TextBox Altura
        txtAltura=new TextBox();
        txtAltura.Size = new Size(100,20);
        txtAltura.Location= new Point(60,75);
        txtAltura.Visible=false;

        //Etiqueta Base
        lblBase= new Label();
        lblBase.Text="Base";
        lblBase.AutoSize=true;
        lblBase.Location= new Point(10,100);
        lblBase.Visible=false;

        //TextBox Base
        txtBase=new TextBox();
        txtBase.Size = new Size(100,20);
        txtBase.Location= new Point(60,100);
        txtBase.Visible=false;

        //Etiqueta cateto C
        lblCC= new Label();
        lblCC.Text="Cateto C";
        lblCC.AutoSize=true;
        lblCC.Location= new Point(10,125);
        lblCC.Visible=false;

        //TextBox Cateto C
        txtCC=new TextBox();
        txtCC.Size = new Size(100,20);
        txtCC.Location= new Point(60,125);
        txtCC.Visible=false;

        //Etiqueta Resultado
        lblResultado= new Label();
        lblResultado.Text="Resultado";
        lblResultado.AutoSize=true;
        lblResultado.Location= new Point(10,280);

        //TextBox Prueba
        txtResultado=new TextBox();
        txtResultado.Size = new Size(100,20);
        txtResultado.Location= new Point(70,275);

        //Boton Calcular
        btnCalcular= new Button();
        btnCalcular.Text="Calcular";
        btnCalcular.AutoSize=true;
        btnCalcular.Location= new Point(200,200);
        btnCalcular.Click+= new EventHandler(btnCalcular_Click);

        //Agregar controles a la ventana
        this.Controls.Add(lblFigura);
        this.Controls.Add(cmbFiguras);
        this.Controls.Add(lblCalculo);
        this.Controls.Add(cmbCalculos);
        this.Controls.Add(lblAltura);
        this.Controls.Add(txtAltura);
        this.Controls.Add(lblBase);
        this.Controls.Add(txtBase);
        this.Controls.Add(lblCC);
        this.Controls.Add(txtCC);
        this.Controls.Add(lblResultado);
        this.Controls.Add(txtResultado);
        this.Controls.Add(btnCalcular);

    }

    private void cmb_ValueChanged(object sender, EventArgs e){
        if(cmbCalculos.SelectedIndex!=0 && cmbFiguras.SelectedIndex!=0){
            if(cmbFiguras.SelectedItem.ToString()=="Cuadrado"){
                //cmbFigura.SelectedIndex==1
                if(cmbCalculos.SelectedItem.ToString()=="Périmetro"){
                    txtAltura.Visible=true;
                    lblAltura.Visible=true;

                }else{
                    txtBase.Visible=false;
                    lblBase.Visible=false;
                    txtCC.Visible=false;
                    lblCC.Visible=false;
                }
                if(cmbCalculos.SelectedItem.ToString()=="Área"){
                    txtAltura.Visible=true;
                    lblAltura.Visible=true;
                    
                }else{
                    txtBase.Visible=false;
                    lblBase.Visible=false;
                    txtCC.Visible=false;
                    lblCC.Visible=false;
                }
            }else{
                txtAltura.Visible=false;
                lblAltura.Visible=false;
            }
        }else{
            txtAltura.Visible=false;
            lblAltura.Visible=false;
            txtBase.Visible=false;
            lblBase.Visible=false;
        }
        if(cmbCalculos.SelectedIndex!=0 && cmbFiguras.SelectedIndex!=0){
            if(cmbFiguras.SelectedItem.ToString()=="Triangulo"){
                if(cmbCalculos.SelectedItem.ToString()=="Périmetro"){
                    txtAltura.Visible = true;
                    lblAltura.Visible = true;   
                    txtBase.Visible = true;
                    lblBase.Visible = true;
                    txtCC.Visible = true;
                    lblCC.Visible = true;
                }else{
                    txtAltura.Visible=true;
                    lblAltura.Visible=true;
                    txtBase.Visible=true;
                    lblBase.Visible=true;
                    txtCC.Visible=false;
                    lblCC.Visible=false;
                }
            }
        }else
        {
            txtAltura.Visible=false;
            lblAltura.Visible=false;
            txtBase.Visible=false;
            lblBase.Visible=false;
            txtCC.Visible=false;
            lblCC.Visible=false;
        }
        if(cmbCalculos.SelectedIndex!=0 && cmbFiguras.SelectedIndex!=0){
            if(cmbFiguras.SelectedItem.ToString()=="Rectangulo"){
                if(cmbCalculos.SelectedItem.ToString()=="Périmetro"){
                    txtAltura.Visible = true;
                    lblAltura.Visible = true;   
                    txtBase.Visible = true;
                    lblBase.Visible = true;
                    txtCC.Visible = false;
                    lblCC.Visible = false;
                }else{
                    txtAltura.Visible=true;
                    lblAltura.Visible=true;
                    txtBase.Visible=true;
                    lblBase.Visible=true;
                    txtCC.Visible=false;
                    lblCC.Visible=false;
                }
            }
        }else
        {
            txtAltura.Visible=false;
            lblAltura.Visible=false;
            txtBase.Visible=false;
            lblBase.Visible=false;
            txtCC.Visible=false;
            lblCC.Visible=false;
        }
    }
    private void btnCalcular_Click(object sender, EventArgs e){
        if(cmbCalculos.SelectedIndex!=0 && cmbFiguras.SelectedIndex!=0){
            if(cmbFiguras.SelectedItem.ToString()=="Cuadrado"){
                string calculo= cmbCalculos.SelectedItem.ToString();
                if(txtAltura.Text!=""){
                    if(calculo=="Périmetro"){
                        int altura= Convert.ToInt32(txtAltura.Text);
                        txtResultado.Text=(altura*4).ToString();
                    }
                    if(calculo=="Área"){
                        int altura= Convert.ToInt32(txtAltura.Text);
                        txtResultado.Text=(altura*altura).ToString();
                    }
                }
            }
            else if(cmbFiguras.SelectedItem.ToString()=="Triangulo"){
                string calculo= cmbCalculos.SelectedItem.ToString();
                if(txtAltura.Text!=""){
                    if(calculo=="Périmetro"){
                        int Base= Convert.ToInt32(txtBase.Text);
                        int altura= Convert.ToInt32(txtAltura.Text);
                        int CC= Convert.ToInt32(txtCC.Text);
                        txtResultado.Text=((Base * altura) * CC).ToString();
                    }
                    if(calculo=="Área"){
                        int altura= Convert.ToInt32(txtAltura.Text);
                        int Base = Convert.ToInt32(txtBase.Text);
                        txtResultado.Text=((Base*altura)/2).ToString();
                    }
                }
            }else if(cmbFiguras.SelectedItem.ToString()=="Rectangulo"){
                string calculo= cmbCalculos.SelectedItem.ToString();
                if(txtAltura.Text!=""){
                    if(calculo=="Périmetro"){
                        int Base= Convert.ToInt32(txtBase.Text);
                        int altura= Convert.ToInt32(txtAltura.Text);
                        txtResultado.Text=((Base + altura) * 2).ToString();
                    }
                    if(calculo=="Área"){
                        int altura= Convert.ToInt32(txtAltura.Text);
                        int Base = Convert.ToInt32(txtBase.Text);
                        txtResultado.Text=((Base*altura)).ToString();
                    }
                }
            }
        }
    }
}
