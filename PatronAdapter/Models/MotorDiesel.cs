namespace PatronAdapter.Models
{
    public class MotorDiesel : Motor
    {
        public override string Acelerar()
        {
            return "Acelerando motor...";
        }

        public override string Arrancar()
        {
            return "Arrancando motor...";
        }

        public override string cargarCombustible()
        {
            return "cargando combustible...";
        }

        public override string Detener()
        {
            return "Deteniendo motor...";
        }
    }
}
