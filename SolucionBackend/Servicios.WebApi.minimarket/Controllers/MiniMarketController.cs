using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Dominio.minimarket.Entidades.DTO;
using Infraestructura.minimarket.Repositorio;

namespace Servicios.WebApi.minimarket.Controllers
{
    public class MiniMarketController : ApiController
    {
        MarketRepositorio repositorio = new MarketRepositorio();
        // GET: api/MiniMarket
        public IEnumerable<ProductoDTO> Get()
        {

            List<ProductoDTO> resultadoConsulta = repositorio.ConsultarProductos();


            return resultadoConsulta;
        }

        // GET: api/MiniMarket/5
        public ProductoDTO Get(int id)
        {
            ProductoDTO resultadoConsulta = repositorio.ConsultarProducto(id);


            return resultadoConsulta;
        }

        // POST: api/MiniMarket
        public string Post([FromBody] ProductoDTO producto)
        {

            string respuesta = string.Empty;
            repositorio.GuardarProducto(producto, ref respuesta);

            if(respuesta == "Transaccion exitosa")
            {
                return respuesta;
            }
            else
            {
                return respuesta;
            }
        }

        // PUT: api/MiniMarket/5
        public string Put(int id, [FromBody] ProductoDTO producto)
        {
            string respuesta = string.Empty;
            producto.id = id;
            repositorio.ModificarProducto(producto, ref respuesta);

            if (respuesta == "Transaccion exitosa")
            {
                return respuesta;
            }
            else
            {
                return respuesta;
            }
        }

        // DELETE: api/MiniMarket/5
        public void Delete(int id)
        {
        }
    }
}

