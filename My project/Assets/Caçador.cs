using UnityEngine;

public class Caçador : MonoBehaviour
{
    [SerializeField] private string nome;
    [SerializeField] private int energia;
    [SerializeField] private int armadilhas;
    [SerializeField] private int forcaDoArco;
    [SerializeField] private float velocidade;
    [SerializeField] private bool armadilhaDeUrso;



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


    public void AtribuirArmadilhas(int armadilhas)
    {
        this.armadilhas = armadilhas;
    }

    public int Armadilhas()
    {
        return this.armadilhas;
    }


    public void AtribuirVelocidade(float velocidade)
    {
        this.velocidade = velocidade;
    }

    public float Velocidade()
    {
        return this.velocidade;
    }



    public void AtribuirForcaDoArco(int forca)
    {
        this.forcaDoArco = forca;
    }

    public int ForcaDoArco()
    {
        return this.forcaDoArco;
    }

    public void atribuirArmadilhaDeUrso(bool armadilhaDeUrso)
    {
        this.armadilhaDeUrso = armadilhaDeUrso;
    }
    public bool ArmadilhaDeUrso()
    {
        return this.armadilhaDeUrso;
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
        AtribuirNome("Caçador");
        AtribuirEnergia(100);
        AtribuirArmadilhas(5);
        AtribuirForcaDoArco(20);
        AtribuirVelocidade(10);
        atribuirArmadilhaDeUrso(true);
    }
}