using System.Globalization;
using System.Security.Cryptography.X509Certificates;

namespace PatronAdapter.Models
{
    public class MotorElectricocs
    {
        bool _concectando = true;
        bool _activo = true;
        bool _moviendo = true;

        public string Conectar() {

            if (_concectando)
            {
                return ("imposible conectarse");
            }
            else {
                _concectando = true;
                return ("Motor conectado exitosamente");
            }        
            
        }
        public string Activar() {

            if (!_concectando)
            {
                return ("imposible activar un motor que no essta conectado");
            }
            else
            {
                _activo = true;
                return ("Motor activado exitosamente");
            }
        }
        public string Mover() {

            if (_concectando && _activo)
            {
                _moviendo = true;
                string mensaje = ("Motor moviendose");
                return mensaje;
            }
            else
            {
                string mensaje = ("Motor deberia estar conectado y activo!!!");
                return mensaje;

            }

        }

        public string Parar() {

            if (_moviendo)
            {
                _moviendo =false;
                return ("Deteniendo motor");
            }
            else
            {
                return ("Motor deberia estar en movimiento");
            }

        }

        public string Enchufar() {

            if (!_activo)
            {
                return ("Imposible enchufar un motor activo!!!");
            }
            else
            {
                _activo = false;
                return ("Motor cargando sus bateria...");
                
            }
        }
    }
}
