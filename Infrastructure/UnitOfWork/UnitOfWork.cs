using Core.Entities;
using Core.Interfaces;
using Infrastructure.Data;
using Infrastructure.Repositories;

namespace Infrastructure.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly TiendaContext _context;
        private CiudadRepository _Ciudades;
        private ContactoPersonaRepository _ContactosPersonas;
        private DepartamentoRepository _Departamentos;
        private DetalleMovimientoInventarioRepository _DetalleMovimientosInventarios;
        private FacturaRepository _Facturas;
        private FormaPagoRepository _FormasPagos;
        private InventarioRepository _Inventarios;
        private MarcaRepository _Marcas;
        private MovimientoInventarioRepository _MovimientoInventarios;
        private PaisRepository _Paises;
        private PersonaRepository _Personas;
        private PresentacionRepository _Presentaciones;
        private ProductoRepository _Productos;
        private RolPersonaRepository _RolesPersonas;
        private TipoContactoRepository _TiposContactos;
        private TipoDocumentoRepository _TiposDocumentos;
        private TipoMovimientoInventarioRepository _TiposMovimientosInventarios;
        private TipoPersonaRepository _TiposPersonas;
        private UbicacionPersonaRepository _UbicacionesPersonas;
        public UnitOfWork(TiendaContext context)
        {
            _context = context;
        }
        
        public void Dispose()
        {
            _context.Dispose();
        }
        public async Task<int> SaveAsync()
        {
            return await _context.SaveChangesAsync();
        }
        
        
    }
}