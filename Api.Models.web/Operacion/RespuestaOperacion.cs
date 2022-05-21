using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Api.Models.web.Operacion
{
 public   class RespuestaOperacion:IRespuestaOperacion
    {
        public RespuestaOperacion()
        {
            this.CodigoEstatus(CodigoEstatusEnum.OK);
        }
        public List<Exception> Error { get; set; }

        public void AgregarExcepcion(Exception ex)
        {
            if (this.Error == null)
                this.Error = new List<Exception>();
            this.Error.Add(new Exception(ex.Message));
        }
        public bool OK()
        {
            return this.Code == ((int)CodigoEstatusEnum.OK).ToString();
        }
        public void CodigoEstatus(CodigoEstatusEnum StatusCodesEnum)
        {
            this.Code = ((int)StatusCodesEnum).ToString();
            this.Message = StatusCodesEnum.ToString();
            if (StatusCodesEnum != CodigoEstatusEnum.OK)
                this.Error = new List<Exception>();
        }
        public enum CodigoEstatusEnum
        {
            OK = 200,
            CREATED = 201,           
            BAD_REQUEST = 400,           
            NOT_FOUND = 404,
            METHOD_NOT_ALLOWED = 405,           
            INTERNAL_SERVER_ERROR = 500,
           
        }
    }
}
