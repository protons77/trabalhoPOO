using UnityEngine;

public class Arqueiro : Personagem
{
    [SerializeField] private string arma = "Arco longo";
    [SerializeField] private int quantidadeFlechas = 30;
    [SerializeField] private string habilidadeEspecial = "Tiro Preciso";

    public string Arma => arma;
    public int QuantidadeFlechas
    {
        get { return quantidadeFlechas; }
        set { quantidadeFlechas = value; }
    }
    public string HabilidadeEspecial => habilidadeEspecial;

    // Você pode criar métodos especiais do arqueiro aqui
    public void UsarHabilidadeEspecial()
    {
        Debug.Log($"{Nome} usou {habilidadeEspecial}!");
        // Lógica da habilidade pode ser implementada
    }
}