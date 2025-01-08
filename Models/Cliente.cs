namespace AdminSERMAC.Models
{
    public class Cliente
    {
        public string? RUT { get; set; }
        public string? Nombre { get; set; }
        public string? Direccion { get; set; }
        public string? Giro { get; set; }
        public double Deuda { get; set; }

        public const string SELECT_ALL = @"
    SELECT * FROM Clientes";
    }
}
