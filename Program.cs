using System;
class Articulo
{
    private string codigo;
    private string descripcion;
    private double precio;
    private int existencia;

    public string Codigo
    {
        get { return codigo; }
        set { codigo = value; }
    }

    public string Descripcion
    {
        get { return descripcion; }
        set { descripcion = value; }
    }

    public double Precio
    {
        get { return precio; }
        set { precio = value; }
    }

    public int Existencia
    {
        get { return existencia; }
        set
        {
            if (value >= 0)
            {
                existencia = value;
            }
        }
    }

    public void VenderArticulo(int cantidad)
    {
        if (cantidad <= Existencia)
        {
            Existencia -= cantidad;

            Console.WriteLine("Venta realizada.");
            Console.WriteLine("Stock restante: " + Existencia);

            if (Existencia < 5)
            {
                GenerarOrdenCompraProveedor();
            }
        }
        else
        {
            Console.WriteLine("No hay suficiente stock.");
        }
    }

    private void GenerarOrdenCompraProveedor()
    {
        Console.WriteLine("ALERTA: Generar orden de compra al proveedor.");
    }
}

class Program
{
    static void Main()
    {
        Articulo articulo = new Articulo();

        articulo.Codigo = "T001";
        articulo.Descripcion = "Teclado Gamer";
        articulo.Precio = 1500;
        articulo.Existencia = 8;

        Console.WriteLine("=== INVENTARIO INICIAL ===");
        Console.WriteLine("Codigo: " + articulo.Codigo);
        Console.WriteLine("Descripcion: " + articulo.Descripcion);
        Console.WriteLine("Precio: " + articulo.Precio);
        Console.WriteLine("Existencia: " + articulo.Existencia);

        Console.WriteLine("\nCliente compra 3 teclados:");
        articulo.VenderArticulo(3);

        Console.WriteLine("\nCliente compra 2 teclados:");
        articulo.VenderArticulo(2);

        Console.WriteLine("\nCliente compra 10 teclados:");
        articulo.VenderArticulo(10);
    }
}