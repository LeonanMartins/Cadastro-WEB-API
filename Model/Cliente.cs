namespace Cadastro.Model
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string TipoFormacao { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }
        public DateTime DataContacto { get; set; }
        public string HorarioContacto { get; set; }
        public bool Retorno { get; set; }
        public int NumeroContactos { get; set; }
        public DateTime PrimeiroContacto { get; set; }
        public DateTime UltimoContacto { get; set; }
        public DateTime Contacto { get; set; }
        public string Obs { get; set; }




    }
}
