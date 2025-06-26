using UnityEngine;

public class Personagem : MonoBehaviour
{
    [SerializeField]
    private string nome;
    [SerializeField]
    private int energia;
    [SerializeField]
    private float velocidade;
    [SerializeField]
    private int forcaAtaque;

   
    public void AtribuirNome(string nome)
    {
        this.nome = nome;
    }

    public string Nome()
    {
        return this.nome;
    }

  
    public void AtribuirEnergia(int energia)
    {
        this.energia = energia;
    }

    public int Energia()
    {
        return this.energia;
    }


    public void AtribuirVelocidade(float velocidade)
    {
        this.velocidade = velocidade;
    }

    public float Velocidade()
    {
        return this.velocidade;
    }

    
    public void AtribuirForcaAtaque(int forca)
    {
        this.forcaAtaque = forca;
    }

    public int ForcaAtaque()
    {
        return this.forcaAtaque;
    }
    public bool CompareVelocidade( Personagem personagem )
    {
        if (this.velocidade > personagem.Velocidade())
        {
            return true;
        }
        return false;
    }

    void Start()
    {
        AtribuirNome("Personagem");
        AtribuirEnergia(100);
        AtribuirVelocidade(5.5f);
        AtribuirForcaAtaque(20);
    }
}