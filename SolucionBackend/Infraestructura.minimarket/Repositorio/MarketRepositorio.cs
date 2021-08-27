using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio.minimarket.Entidades.DTO;
using Infraestructura.minimarket.DataModel;


namespace Infraestructura.minimarket.Repositorio
{
    public class MarketRepositorio
    {
        SINERGIAEntities modelDb = new SINERGIAEntities();

        public void GuardarProducto(ProductoDTO producto, ref string codigoRespuesta)
        {

            try
            {
                tproducto productodb = new tproducto();

               // productodb.id = producto.id;
                productodb.descripcion = producto.descripcion;
                productodb.medidas = producto.medidas;
                productodb.cantidad = producto.cantidad;
                productodb.precio = producto.precio;
                productodb.marcaid = producto.marcaid;
                productodb.proveedorid = producto.proveedorid;
                productodb.categoriaid = producto.categoriaid;

                modelDb.tproducto.Add(productodb);

                modelDb.SaveChanges();

                codigoRespuesta = "Transaccion exitosa";
            }
            catch (Exception ex)
            {
                codigoRespuesta = ex.Message;
            }

            

        }

        public void ModificarProducto(ProductoDTO producto, ref string codigoRespuesta)
        {

            try
            {
                tproducto productoBase = (from e in modelDb.tproducto where e.id == producto.id select e).FirstOrDefault();


                if (productoBase != null)
                {
                    productoBase.descripcion = producto.descripcion;
                    productoBase.medidas = producto.medidas;
                    productoBase.cantidad = producto.cantidad;
                    productoBase.precio = producto.precio;

                    modelDb.SaveChanges();

                    codigoRespuesta = "Transaccion exitosa";
                }
            }
            catch (Exception ex)
            {

                codigoRespuesta = ex.Message;
            }

           


        }

        public ProductoDTO ConsultarProducto(int id)
        {
            ProductoDTO producto = new ProductoDTO();

            consultarProducto_SP_Result resultado = modelDb.consultarProducto_SP(id).FirstOrDefault();//sp
            if(resultado != null)
            {
                producto.id = resultado.id;
                producto.descripcion = resultado.descripcion;
                producto.medidas = resultado.medidas;
                producto.cantidad = resultado.cantidad;
                producto.precio = resultado.precio;
            }
                
             
            return producto;

        }

        public List<ProductoDTO> ConsultarProductos()
        {

            List<ProductoDTO> productos = new List<ProductoDTO>();

            List< consultaProductoTodo_SP_Result> resultado = modelDb.consultaProductoTodo_SP().ToList();//sp

            ProductoDTO producto = new ProductoDTO();

            foreach (var item in resultado)
            {
                producto = new ProductoDTO();
                producto.id = item.id;
                producto.descripcion = item.descripcion;
                producto.medidas = item.medidas;
                producto.cantidad = item.cantidad;
                producto.precio = item.precio;
                
                productos.Add(producto);

            }
         

            return productos;


        }

    }
}
