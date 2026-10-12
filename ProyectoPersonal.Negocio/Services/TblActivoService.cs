using ProyectoFinal.Datos.Interfaces;
using ProyectoPersonal.Datos.Entities;
using ProyectoPersonal.Datos.Interfaces;
using ProyectoPersonal.Negocio.DTOs.TblActivo;
using ProyectoPersonal.Negocio.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoPersonal.Negocio.Services
{
    public class TblActivoService : ITblActivoService
    {
        private readonly ITblActivoRepository _tblActivoRepository;
        public TblActivoService(ITblActivoRepository tblActivoRepository)
        {
            _tblActivoRepository = tblActivoRepository;
        }

        public async Task Actualizar(TblActivoUpdateDto activo)
        {
            TblActivo objActivo = new TblActivo
            {
                lActivo_id = activo.lActivo_id,
                sActivo_nm = activo.sActivo_nm,
                sActivo_CodUnico = activo.sActivo_CodUnico,
                sActivo_fecha_registro = activo.sActivo_fecha_registro,
                sActivo_Estado = activo.sActivo_Estado,
                lEspacio_id = activo.lEspacio_id,
                lCategoria_id = activo.lCategoria_id,
                lProducto_id = activo.lProducto_id
            };
            await _tblActivoRepository.Actualizar(objActivo);
        }

        public async Task Crear(TblActivoCreateDto activo)
        {
            TblActivo objActivo = new TblActivo
            {
                sActivo_nm = activo.sActivo_nm,
                sActivo_CodUnico = activo.sActivo_CodUnico,
                sActivo_fecha_registro = activo.sActivo_fecha_registro,
                sActivo_Estado = activo.sActivo_Estado,
                lEspacio_id = activo.lEspacio_id,
                lCategoria_id = activo.lCategoria_id,
                lProducto_id = activo.lProducto_id
            };
            await _tblActivoRepository.Crear(objActivo);
        }

        public async Task Eliminar(int idActivo)
        {
            await _tblActivoRepository.Eliminar(idActivo);
        }

        public async Task<TblActivoReadDto> ObtenerPorId(int idActivo)
        {
            var result = await _tblActivoRepository.ObtenerPorId(idActivo);

            if (result is null) return null;

            return new TblActivoReadDto
            {
                lActivo_id = result.lActivo_id,
                sActivo_nm = result.sActivo_nm,
                sActivo_CodUnico = result.sActivo_CodUnico,
                sActivo_fecha_registro = result.sActivo_fecha_registro,
                sActivo_Estado = result.sActivo_Estado,
                lEspacio_id = result.lEspacio_id,
                lCategoria_id = result.lCategoria_id,
                lProducto_id = result.lProducto_id
            };
        }

        public async Task<List<TblActivoReadDto>> ObtenerTodos()
        {
            var activos = await _tblActivoRepository.ObtenerTodos();
            var activosDTO = new List<TblActivoReadDto>();

            foreach (var activo in activos)
            {
                var activoDTO = new TblActivoReadDto
                {
                    lActivo_id = activo.lActivo_id,
                    sActivo_nm = activo.sActivo_nm,
                    sActivo_CodUnico = activo.sActivo_CodUnico,
                    sActivo_fecha_registro = activo.sActivo_fecha_registro,
                    sActivo_Estado = activo.sActivo_Estado,
                    lEspacio_id = activo.lEspacio_id,
                    lCategoria_id = activo.lCategoria_id,
                    lProducto_id = activo.lProducto_id
                };

                activosDTO.Add(activoDTO);
            }

            return activosDTO;
        }
    }
}