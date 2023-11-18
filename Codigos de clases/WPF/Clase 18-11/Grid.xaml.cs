public partial class MainWindow : Window
{
    List<ItemListado> ListaCompras = new List<ItemListado>();

    public MainWindow()
    {
        InitializeComponent();
    }

    private void AgregarItem(object sender, RoutedEventArgs e)
    {
        // pasos:
        // 1- preguntar
        // 2- si es si, agrego, sino... nada

        // paso 1
        MessageBoxResult decision = MessageBox.Show("contenido", "titulo",
            MessageBoxButton.OKCancel);

        // paso 2
        if(decision == MessageBoxResult.OK)
        {
            // Creamos un item vacio para cargar los datos
            ItemListado item = new ItemListado();

            // paso de la ventana al objetos los datos
            item.NombreProducto = txtProducto.Text;
            item.Cantidad = int.Parse(txtCantidad.Text);
            item.FechaAgregado = DateTime.Now;

            // guardo el item en la lista
            ListaCompras.Add(item);

            // toma todos los items de la lista y los muestra en 
            // el datagrid
            dtgProductos.ItemsSource = null;
            dtgProductos.ItemsSource = ListaCompras;
        }
    }

    private void RemoverItem(object sender, RoutedEventArgs e)
    {
        /* pasos:
         * 1 Obtener el item a eliminar
         * 1.1 Si no se selecciono item, avisarle al usuario, sinó
         * 2 Con ese item sacar el que corresponde de la lista
         * 3 Actualizar el datagrid */

        // paso 1
        ItemListado itemAEliminar = dtgProductos.SelectedItem as ItemListado;

        // paso 1.1
        if (itemAEliminar == null)
        {
            // no se selecciono item, mostrar mensaje al usuario
            MessageBox.Show("Primero tenés que seleccionar un elemento");
        }
        else
        {
            // tenemos el item, hay que borrarlo
            // paso 2
            ListaCompras.Remove(itemAEliminar);

            // paso 3
            dtgProductos.ItemsSource = null;
            dtgProductos.ItemsSource = ListaCompras;
        }
    }
