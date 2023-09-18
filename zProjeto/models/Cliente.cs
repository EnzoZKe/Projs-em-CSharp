namespace Clientela;
public class Cliente
{
    private string Nome { get; set; }
    private int CPF { get; set; }
    private int CEP { get; set; }
    private int CasaNum { get; set; }
    private string Rua { get; set; }
    private string Email { get; set; }
    private string Senha { get; set; }
    private int Telefone { get; set; }

    private int IDuser { get; set; }

    public Cliente(string Nome, int CPF, int CEP, int CasaNum, string Rua, string Email, string Senha)
    {
        this.Nome = Nome;
        this.CPF = CPF;
        this.CEP = CEP;
        this.CasaNum = CasaNum;
        this.Rua = Rua;
        this.Email = Email;
        this.Senha = Senha;
        this.Telefone = Telefone;
        this.IDuser = 0;
    }
}