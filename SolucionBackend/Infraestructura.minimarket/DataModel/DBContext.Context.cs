﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Infraestructura.minimarket.DataModel
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class SINERGIAEntities : DbContext
    {
        public SINERGIAEntities()
            : base("name=SINERGIAEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tcategoria> tcategoria { get; set; }
        public virtual DbSet<tmarca> tmarca { get; set; }
        public virtual DbSet<tproducto> tproducto { get; set; }
        public virtual DbSet<tproveedor> tproveedor { get; set; }
    
        public virtual ObjectResult<consultaCategoria_SP_Result> consultaCategoria_SP()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<consultaCategoria_SP_Result>("consultaCategoria_SP");
        }
    
        public virtual ObjectResult<consultaMarca_SP_Result> consultaMarca_SP()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<consultaMarca_SP_Result>("consultaMarca_SP");
        }
    
        public virtual ObjectResult<consultaProductoTodo_SP_Result> consultaProductoTodo_SP()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<consultaProductoTodo_SP_Result>("consultaProductoTodo_SP");
        }
    
        public virtual ObjectResult<consultaProveedor_SP_Result> consultaProveedor_SP()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<consultaProveedor_SP_Result>("consultaProveedor_SP");
        }
    
        public virtual ObjectResult<consultarProducto_SP_Result> consultarProducto_SP(Nullable<int> idProducto)
        {
            var idProductoParameter = idProducto.HasValue ?
                new ObjectParameter("idProducto", idProducto) :
                new ObjectParameter("idProducto", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<consultarProducto_SP_Result>("consultarProducto_SP", idProductoParameter);
        }
    }
}
