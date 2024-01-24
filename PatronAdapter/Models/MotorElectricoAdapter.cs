namespace PatronAdapter.Models
{
    public class MotorElectricoAdapter : Motor
    {
        MotorElectricocs motorElectrico = new MotorElectricocs();
        public override string Acelerar()
        {
           return motorElectrico.Mover();
        }

        public override string Arrancar()
        {
            return motorElectrico.Activar();
        }

        public override string cargarCombustible()
        {
            return motorElectrico.Enchufar(); 
        }

        public override string Detener()
        {
           return motorElectrico.Parar();   
        }
    }
}
