private void MostrarSaludo(object sender, RoutedEventArgs e)
{
    // Instancio un objeto para cargar los datos
    Persona p = new Persona();

    // asigno las propiedades del objetos desde los controles
    // de la ventana
    p.Nombre = txtNombre.Text;
    p.Apellido = txtApellido.Text;

    bool Correcto; // para manera corta no necesito esta variable

    Correcto = p.Validar();

    // manera corta -> if ( p.Validar() )
    if (Correcto)
    {
        // Mostrar nombre y apellido en un messagebox
        MessageBox.Show($"Persona: {p.Nombre}, {p.Apellido}", "Muestranombre");
    }
    else
    {
        MessageBox.Show("Debe escribir nombre y apellido");
    }

    /*
    string nombreDesdeVentana;
    string apellidoDesdeVentana;
    // Leemos los valores de los textbox
    nombreDesdeVentana = txtNombre.Text;
    apellidoDesdeVentana = txtApellido.Text;

    MessageBox.Show(
        $"Hola {nombreDesdeVentana}, {apellidoDesdeVentana}!",
        "Alerta!");
    */
}

private void Reset(object sender, RoutedEventArgs e)
{
    // Escribimos un valor nuevo en cada textbox
    txtNombre.Text = "";
    txtApellido.Text = "";
}
