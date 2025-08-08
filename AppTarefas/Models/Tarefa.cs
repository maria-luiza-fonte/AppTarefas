namespace AppTarefas.Models
{
    public class Tarefa
    {
        public int TareId { get; set; }
        public string? Título { get; set; }
        public string? Descrição { get; set; }
        public bool Concluída { get; set; }
    }
}
