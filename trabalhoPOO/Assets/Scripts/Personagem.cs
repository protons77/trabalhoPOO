using UnityEngine;

public class Personagem : MonoBehaviour
{
    // Variáveis básicas com SerializeField para expor no Inspector
    [SerializeField] private string nome;
    [SerializeField] private int vida;
    [SerializeField] private int mana;
    [SerializeField] private int forca;

    // Propriedades públicas para acesso
    public string Nome
    {
        get { return nome; }
        set { nome = value; }
    }

    public int Vida
    {
        get { return vida; }
        set { vida = value; }
    }

    public int Mana
    {
        get { return mana; }
        set { mana = value; }
    }

    public int Forca
    {
        get { return forca; }
        set { forca = value; }
    }

    // Função para comparar nomes (ou outra lógica)
    public bool CompararNome(Personagem outro)
    {
        return this.nome == outro.nome;
    }

    // Exemplo: Mostrar nome sobre o personagem (na posição do objeto 3D)
    private void OnDrawGizmos()
    {
        // Desenha o nome no editor (quando selecionado)
        if (!string.IsNullOrEmpty(nome))
        {
            Vector3 pos = transform.position + Vector3.up * 2f;
#if UNITY_EDITOR
            UnityEditor.Handles.Label(pos, nome);
#endif
        }
    }
}