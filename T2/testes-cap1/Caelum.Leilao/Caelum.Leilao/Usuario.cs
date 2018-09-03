namespace Caelum.Leilao
{

    public class Usuario
    {

        public int Id { get; private set; }
        public string Nome { get; private set; }

        public Usuario(string nome) : this(0, nome)
        {
        }

        public Usuario(int id, string nome)
        {
            this.Id = id;
            this.Nome = nome;
        }
        public override bool Equals(object obj)
        {
            if(obj == null || this.GetType() != obj.GetType())
            {
                return false;
            }
            Usuario outro = (Usuario)obj;
            return outro.Id == this.Id && outro.Nome.Equals(this.Nome);
        }
    }
}
