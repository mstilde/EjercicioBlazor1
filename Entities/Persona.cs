namespace EjercicioBlazor.Entities
{
    public abstract class Persona
    {
        public long DNI = 0;
        public string Nombre = string.Empty;
        public string Apellido = string.Empty;
        public DateOnly FechaNacimiento = new();
        public string NombreCompleto
        {
            get
            {
                return $"{Nombre} {Apellido}";
            }
        }
        public Persona(long dni, string nombre, string apellido, DateOnly fechaNacimiento)
        {
            DNI = dni;
            Nombre = nombre;
            Apellido = apellido;
            FechaNacimiento = fechaNacimiento;
        }
        public virtual string DevolverNombreCompleto()
        {
            return $"{Nombre} {Apellido}";
        }
    }
}

