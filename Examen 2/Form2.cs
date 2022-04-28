namespace Examen_2;

public partial class Form2 : Form
{
    public CheckedListBox? checkedListBox1;
    public Button? btnCancelar;
    public Button? btnAceptar;
    public Form2()
    {
        InitializeComponent();
        InicializarComponentes();
        string[] Monedas = {"USD - Dólar Estadounidense", "MXN - Peso Mexicano","CAD - Dólar Canadiense", "EUR - Euro", "JPY - Yen Japonés"};
        checkedListBox1.Items.AddRange(Monedas);
        checkedListBox1.CheckOnClick = true;
    }

    public void InicializarComponentes(){
        this.Size = new Size(320,200);
        
        this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
        this.checkedListBox1.Location = new Point(50, 10);
        this.checkedListBox1.Size = new Size(200,100);
        this.checkedListBox1.TabIndex = 0;
        this.Controls.AddRange(new System.Windows.Forms.Control[] {this.checkedListBox1});

        btnCancelar = new Button();
        btnCancelar.Text="Cancelar";
        btnCancelar.AutoSize=true;
        btnCancelar.Location= new Point(10,120);
        btnCancelar.Click += new EventHandler(btnCancelar_click);
        Controls.Add(btnCancelar);

        btnAceptar = new Button();
        btnAceptar.Text="Aceptar";
        btnAceptar.AutoSize=true;
        btnAceptar.Location= new Point(220,120);
        btnAceptar.Click += new EventHandler(btnAceptar_click);
        Controls.Add(btnAceptar);
    }

    private void btnCancelar_click(Object? sender, EventArgs e){
        this.DialogResult=DialogResult.Cancel;
        this.Close();
    }

    private void btnAceptar_click(Object? sender, EventArgs e){
        this.DialogResult = DialogResult.OK;
        this.Close();
    }
}
