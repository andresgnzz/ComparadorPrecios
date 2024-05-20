using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using HtmlAgilityPack;
using System.IO;
using static System.Net.WebRequestMethods;

namespace ComparadorPrecios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buscar_Click(object sender, EventArgs e)
        {
            int band = 0;
            string prod = producto.Text;

            //Limpiar Objetos
            pGaia.Items.Clear();
            desGaia.Clear();
            precioGaia.Clear();

            pDico.Items.Clear();
            desDico.Clear();
            precioDico.Clear();

            pGarza.Items.Clear();
            desGarza.Clear();
            precioGarza.Clear();

            nombreProductos.Items.Clear();
            precioProductos.Items.Clear();
            menorPrecio.Clear();
            prodMenorPrecio.Clear();

            //Busqueda Muebles Gaia
            HtmlAgilityPack.HtmlDocument doc1 = new HtmlAgilityPack.HtmlDocument();
            string url1 = "https://www.gaiadesign.com.mx/catalogsearch/result/" + prod;

            HtmlWeb web = new HtmlWeb();
            doc1 = web.Load(url1);

            HtmlNodeCollection prd1 = doc1.DocumentNode.SelectNodes("//div[@class='productCard_name__hcMC2']");

            if (prd1 != null)
                foreach(HtmlNode node in prd1)
                {
                    string p1 = node.InnerText.Trim();
                    pGaia.Items.Add(p1);
                    band++;

                    if (band == 5)
                        break;
                }

            //Busqueda Muebles Dico
            band = 0;
            HtmlAgilityPack.HtmlDocument doc2 = new HtmlAgilityPack.HtmlDocument();
            string url2 = "https://bajio.dico.com.mx/bajio/catalogsearch/result/?q=" + prod;

            HtmlWeb web2 = new HtmlWeb();
            doc2 = web2.Load(url2);

            HtmlNodeCollection prd2 = doc2.DocumentNode.SelectNodes("//a[@class='product-item-link']");

            if(prd2 != null)
                foreach(HtmlNode node in prd2)
                {
                    string p2 = node.InnerText.Trim();
                    pDico.Items.Add(p2);
                    band++;

                    if(band == 5)
                        break;
                }

            //Busqueda Muebles Garza
            band = 0;
            HtmlAgilityPack.HtmlDocument doc3 = new HtmlAgilityPack.HtmlDocument();
            string url3 = "https://muebleriasgarza.com.mx/search?q=" + prod;

            HtmlWeb web3 = new HtmlWeb();
            doc3 = web3.Load(url3);

            HtmlNodeCollection prd3 = doc3.DocumentNode.SelectNodes("//a[@class='full-unstyled-link']");

            if(prd3 != null)
                foreach(HtmlNode node in prd3)
                {
                    string p3 = node.InnerText.Trim();
                    pGarza.Items.Add(p3);
                    band++;

                    if(band == 5)
                        break;
                }

            Thread.Sleep(100);
        }

        private void pPlacencia_SelectedIndexChanged(object sender, EventArgs e)
        {
            string productoSeleccionado = pGaia.SelectedItem as string;
            nombreProductos.Items.Add(productoSeleccionado);

            precioGaia.Clear();
            desGaia.Clear();

            if (productoSeleccionado != null)
            {
                string urlProducto = ObtenerEnlaceGaia(productoSeleccionado);
                //Console.WriteLine(urlProducto);

                if (urlProducto != null)
                {
                    HtmlWeb web = new HtmlWeb();
                    HtmlAgilityPack.HtmlDocument doc = web.Load(urlProducto);

                    HtmlNode precioNode = doc.DocumentNode.SelectSingleNode("//span[@class='productPrices_product-prices-container_pdp-price__XMOnH']");

                    if (precioNode != null)
                    {
                        string precio = precioNode.InnerText.Trim();
                        int indice = precio.IndexOf(';');

                        if (indice != -1) 
                        {
                            precio = "$" + precio.Substring(indice + 1).Trim() + ".00"; 
                            precioGaia.Text = precio;
                            precioProductos.Items.Add(precio);
                        }
                        else
                            precioGaia.Text = "Precio no disponible";
                    }
                    else
                        precioGaia.Text = "Precio no disponible";

                    HtmlNode descNode = doc.DocumentNode.SelectSingleNode("//meta[@name='description']");
                    if (descNode != null)
                    {
                        string descripcion = descNode.GetAttributeValue("content", "");
                        desGaia.Text = descripcion; 
                    }
                    else
                        desGaia.Text = "Descripción no disponible";
                }
                else
                    precioGaia.Text = "Error al obtener el enlace";

                Thread.Sleep(100);
            }
        }

        private string ObtenerEnlaceGaia(string nombreProducto)
        {
            string prd = producto.Text;
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();

            string url = "https://www.gaiadesign.com.mx/catalogsearch/result/" + prd;

            HtmlWeb web = new HtmlWeb();
            doc = web.Load(url);

            HtmlNodeCollection prod = doc.DocumentNode.SelectNodes("//a[@alt='"+ nombreProducto + "']");

            if (prod != null)
            {
                foreach (HtmlNode node in prod)
                {
                     HtmlAttribute href = node.Attributes["href"];
                     if (href != null)
                     {
                         string enlace = "https://www.gaiadesign.com.mx" + href.Value;
                         //Console.WriteLine(enlace);
                         return enlace;
                     }
                     else
                     {
                         return null;
                     }
                }
            }

            Thread.Sleep(100);
            return null;
        }

        private void placencia_Click(object sender, EventArgs e)
        {

        }

        private void pDico_SelectedIndexChanged(object sender, EventArgs e)
        {
            string productoSeleccionado = pDico.SelectedItem as string;
            nombreProductos.Items.Add(productoSeleccionado);

            precioDico.Clear();
            desDico.Clear();

            if (productoSeleccionado != null)
            {
                string urlProducto = ObtenerEnlaceDico(productoSeleccionado);
                //Console.WriteLine(urlProducto);

                if (urlProducto != null)
                {
                    HtmlWeb web = new HtmlWeb();
                    HtmlAgilityPack.HtmlDocument doc = web.Load(urlProducto);

                    HtmlNode precioNode = doc.DocumentNode.SelectSingleNode("//span[@data-price-type='finalPrice']");

                    if (precioNode != null)
                    {
                        string precio = precioNode.InnerText.Trim();
                        precioDico.Text = precio;
                        precioProductos.Items.Add(precio);
                    }
                    else
                        precioDico.Text = "Precio no disponible";

                    HtmlNode descNode = doc.DocumentNode.SelectSingleNode("//meta[@name='twitter:description']");

                    if (descNode != null)
                    {
                        string descripcion = descNode.GetAttributeValue("content", "");
                        desDico.Text = descripcion;
                    }
                    else
                        desDico.Text = "Descripción no disponible";                  

                }
                else
                    precioDico.Text = "Error al obtener el enlace";

                Thread.Sleep(100);
            }
        }

        private string ObtenerEnlaceDico(string nombreProducto)
        {
            string prd = nombreProducto; 
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();

            string url = "https://bajio.dico.com.mx/bajio/catalogsearch/result/?q=" + prd;

            HtmlWeb web = new HtmlWeb();
            doc = web.Load(url);

            HtmlNodeCollection prod = doc.DocumentNode.SelectNodes("//a[@class='product-item-link']");

            if (prod != null)
            {
                foreach (HtmlNode node in prod)
                {
                    string nombreNodo = node.InnerText.Trim();

                    if (nombreProducto == nombreNodo)
                    {
                        HtmlAttribute href = node.Attributes["href"];
                        if (href != null)
                        {
                            string enlace = href.Value;
                            //Console.WriteLine(enlace);
                            return enlace; 
                        }
                    }
                }
            }

            Thread.Sleep(100);
            return null;
        }

        private void pGarza_SelectedIndexChanged(object sender, EventArgs e)
        {
            string productoSeleccionado = pGarza.SelectedItem as string;
            nombreProductos.Items.Add(productoSeleccionado);

            precioGarza.Clear();
            desGarza.Clear();

            if (productoSeleccionado != null)
            {
                string urlProducto = ObtenerEnlaceGarza(productoSeleccionado);
                //Console.WriteLine(urlProducto);

                if (urlProducto != null)
                {
                    HtmlWeb web = new HtmlWeb();
                    HtmlAgilityPack.HtmlDocument doc = web.Load(urlProducto);

                    HtmlNode precioNode = doc.DocumentNode.SelectSingleNode("//meta[@property='og:price:amount']");

                    if (precioNode != null)
                    {
                        string precio = "$" + precioNode.GetAttributeValue("content", "");
                        precioGarza.Text = precio;
                        precioProductos.Items.Add(precio);
                    }
                    else
                        precioGarza.Text = "Precio no disponible";

                    HtmlNode descNode = doc.DocumentNode.SelectSingleNode("//meta[@name='description']");

                    if (descNode != null)
                    {
                        string descripcion = descNode.GetAttributeValue("content", "");
                        desGarza.Text = descripcion;
                    }
                    else
                        desGarza.Text = "Descripción no disponible";

                }
                else
                    desGarza.Text = "Error al obtener el enlace";

                Thread.Sleep(100);
            }
        }

        private string ObtenerEnlaceGarza(string nombreProducto)
        {
            string prd = producto.Text;
            HtmlAgilityPack.HtmlDocument doc = new HtmlAgilityPack.HtmlDocument();

            string url = "https://muebleriasgarza.com.mx/search?q=" + prd;

            HtmlWeb web = new HtmlWeb();
            doc = web.Load(url);

            HtmlNodeCollection prod = doc.DocumentNode.SelectNodes("//a[@class='full-unstyled-link']");

            if (prod != null)
            {
                foreach (HtmlNode node in prod)
                {
                    string nombreNodo = node.InnerText.Trim();

                    if (nombreProducto == nombreNodo)
                    {
                        HtmlAttribute href = node.Attributes["href"];
                        if (href != null)
                        {
                            string enlace = "https://muebleriasgarza.com.mx" + href.Value;
                            //Console.WriteLine(enlace);
                            return enlace;
                        }
                    }
                }
            }

            Thread.Sleep(100);
            return null;
        }

        private void buscarMenor_Click(object sender, EventArgs e)
        {
            comparadorPrecios(precioProductos, nombreProductos, menorPrecio, prodMenorPrecio);
        }

        private void comparadorPrecios(ListBox precios, ListBox productos, TextBox MenorPrecio, TextBox ProductoMenorPrecio)
        {
            if (precios.Items.Count == 0 || productos.Items.Count == 0)
            {
                MenorPrecio.Text = "No hay precios";
                return;
            }

            decimal precioMenor = decimal.MaxValue;
            int band = -1;

            for (int i = 0; i < precios.Items.Count; i++)
            {
                string precioStr = precios.Items[i].ToString();

                precioStr = precioStr.Replace("$", "");

                decimal precio = Convert.ToDecimal(precioStr);

                if (precio < precioMenor)
                {
                    precioMenor = precio;
                    band = i;
                }
            }

            if (band != -1)
            {
                string nombreProducto = productos.Items[band].ToString();

                MenorPrecio.Text = precioMenor.ToString("C2"); 
                ProductoMenorPrecio.Text = nombreProducto;
            }
            else
            {
                MenorPrecio.Text = "No hay precios";
                ProductoMenorPrecio.Text = "";
            }
        }
    }
}
