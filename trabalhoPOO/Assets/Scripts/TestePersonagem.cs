using UnityEngine;

public class TestePersonagem : MonoBehaviour
{
    private void Start()
    {
        // Cria um cubo para personagem genérico
        GameObject go1 = GameObject.CreatePrimitive(PrimitiveType.Cube);
        go1.transform.position = new Vector3(-2, 0, 0);
        Personagem personagem1 = go1.AddComponent<Personagem>();
        personagem1.Nome = "Guerreiro";
        personagem1.Vida = 100;
        personagem1.Mana = 50;
        personagem1.Forca = 30;

        // Cria uma esfera para arqueiro
        GameObject go2 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        go2.transform.position = new Vector3(2, 0, 0);
        Arqueiro arqueiro1 = go2.AddComponent<Arqueiro>();
        arqueiro1.Nome = "Legolas";
        arqueiro1.Vida = 80;
        arqueiro1.Mana = 70;
        arqueiro1.Forca = 20;
        arqueiro1.QuantidadeFlechas = 50;

        // Mostra os dados no console
        Debug.Log($"Personagem1: {personagem1.Nome} - Vida: {personagem1.Vida}, Mana: {personagem1.Mana}, Força: {personagem1.Forca}");
        Debug.Log($"Arqueiro: {arqueiro1.Nome} - Vida: {arqueiro1.Vida}, Mana: {arqueiro1.Mana}, Força: {arqueiro1.Forca}, Flechas: {arqueiro1.QuantidadeFlechas}, Habilidade: {arqueiro1.HabilidadeEspecial}");

        // Testar a comparação
        Debug.Log("Comparar nomes: " + personagem1.CompararNome(arqueiro1));  // Deve ser false

        // Testar habilidade especial
        arqueiro1.UsarHabilidadeEspecial();
    }
}