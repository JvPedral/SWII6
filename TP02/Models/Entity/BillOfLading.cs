// João Vitor Pedral do Nascimento CB3022391
// Rodrigo Braga Guimarães Brito CB3018105

namespace TP02.Models.Entity;

public class BillOfLading
{
    public int Id { get; set; }
    public string Numero { get; set; }
    public string Consignee { get; set; }
    public string Navio { get; set; }

    public virtual ICollection<Container>? Containers { get; set; }
}