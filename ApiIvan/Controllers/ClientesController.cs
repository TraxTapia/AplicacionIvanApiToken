using Api.Models.web.BDCliente;
using Api.Models.web.Operacion;
using Api.Models.web.Request;
using Api.Repositorio.ApiCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace ApiIvan.Controllers
{
    [System.Web.Http.RoutePrefix("Clientes")]
    public class ClientesController : ApiController
    {
        public ClientesController()
        {
            
        }

        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("NuevoCliente")]
        public RespuestaOperacion AddClient(ClienteRequest _Request)
        {
            RespuestaOperacion _Response = new RespuestaOperacion();
            try
            {
                if (!ModelState.IsValid)
                {
                    var error = ModelState.Values.SelectMany(x => x.Errors).ToList();
                    var _Errors = ModelState.Values.SelectMany(x => x.Errors).ToList();
                    _Response.CodigoEstatus(RespuestaOperacion.CodigoEstatusEnum.BAD_REQUEST);
                    _Errors.ForEach(x => { if (x.Exception == null) _Response.AgregarExcepcion(new Exception(x.ErrorMessage)); else _Response.AgregarExcepcion(x.Exception); });
                    return _Response;


                }
               
                CoreApi _Core = new CoreApi();
                _Response = _Core.NuevoCliente(_Request.Nombre,_Request.ApPaterno,_Request.ApMaterno,_Request.FechaNacimiento,_Request.IdDomicilio,_Request.IdContacto);
            }
            catch (Exception ex)
            {
                _Response.AgregarExcepcion(ex);
            }
            return _Response;
        }
        public RespuestaOperacion UpdateClient(UpdateClienteRequest _Request)
        {
            RespuestaOperacion _Response = new RespuestaOperacion();
            try
            {

                CoreApi _Core = new CoreApi();
                _Response = _Core.NuevoCliente(_Request.Nombre, _Request.ApPaterno, _Request.ApMaterno, _Request.FechaNacimiento, _Request.IdDomicilio, _Request.IdContacto);
            }
            catch (Exception ex)
            {
                _Response.AgregarExcepcion(ex);
            }
            return _Response;
        }
    }
}