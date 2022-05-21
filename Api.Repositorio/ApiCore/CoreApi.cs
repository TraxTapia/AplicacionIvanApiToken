using Api.Models.web.BDCliente;
using Api.Models.web.Operacion;
using Api.Repositorio.Repositorio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Repositorio.ApiCore
{
    public class CoreApi
    {
        public RespuestaOperacion NuevoCliente(string _Nombre, string _ApPaterno, string _ApMaterno, DateTime? _FechaNacimiento, int? _IdDomicilio, int? _IdContacto)
        {
            RespuestaOperacion Response = new RespuestaOperacion();
            Cliente _Register = new Cliente()
            {
                Nombre = _Nombre,
                ApPaterno = _ApPaterno,
                ApMaterno = _ApMaterno,
                FechaNacimiento = _FechaNacimiento,
                IdDomicilio = _IdDomicilio,
                IdContacto = _IdContacto,
                Activo = 1
            };
            RepositorioApi _Repository = new RepositorioApi();
            _Repository.Add(_Register);
            return Response;

        }
        public RespuestaOperacion UpdateClient(int _Id, string _Nombre, string _ApPaterno, string _ApMaterno, DateTime? _FechaNacimiento, int? _IdDomicilio, int? _IdContacto)
        {
            RespuestaOperacion Response = new RespuestaOperacion();
            Cliente _Register = new Cliente()
            {
                Nombre = _Nombre,
                ApPaterno = _ApPaterno,
                ApMaterno = _ApMaterno,
                FechaNacimiento = _FechaNacimiento,
                IdDomicilio = _IdDomicilio,
                IdContacto = _IdContacto,
                Activo = 1
            };
            RepositorioApi _Repository = new RepositorioApi();
            _Repository.Add(_Register);
            return Response;
        }
    }
}
