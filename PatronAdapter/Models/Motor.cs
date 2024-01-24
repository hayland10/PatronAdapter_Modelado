namespace PatronAdapter.Models
{
    public abstract class Motor
    {
        public abstract string Acelerar();
        public abstract string Arrancar();
        public abstract string Detener();
        public abstract string cargarCombustible();

    }
}
