namespace PatronAdapter.Models
{
    public class MotorSuper : Motor
    {
        public override string Acelerar()
        {
            return ("Acelerando motor super...");
        }

        public override string Arrancar()
        {
            return ("Arrancando motor super...");
        }

        public override string cargarCombustible()
        {
            return ("cargando combustible super...");
        }

        public override string Detener()
        {
            {
                return ("Deteniendo motor super...");
            }
        }
    }
}