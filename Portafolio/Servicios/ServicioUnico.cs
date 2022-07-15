namespace Portafolio.Servicios
{
    public class ServicioUnico
    {
        public ServicioUnico()
        {// GUID --> STRING ALEATRIO LARGO
            ObtenerGuid = Guid.NewGuid();
        }
        public Guid ObtenerGuid { get; private set; }

    }
    public class ServicioDelimitado
    {
        public ServicioDelimitado()
        {// GUID --> STRING ALEATRIO LARGO
            ObtenerGuid = Guid.NewGuid();
        }
        public Guid ObtenerGuid { get; private set; }

    }

    public class ServicioTransitorio
    {
        public ServicioTransitorio()
        {// GUID --> STRING ALEATRIO LARGO
            ObtenerGuid = Guid.NewGuid();
        }
        public Guid ObtenerGuid { get; private set; }

    }
}




