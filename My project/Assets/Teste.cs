using UnityEngine;

public class Teste : MonoBehaviour
{
    public Personagem personagem;
    public Caçador caçador;
    void Start()
    {
       

        personagem.AtribuirNome("Personagem");
        personagem.AtribuirEnergia(100);
        personagem. AtribuirVelocidade(5f);
        personagem.AtribuirForcaAtaque(20);
        
        caçador.AtribuirNome("Caçador");
        caçador.AtribuirEnergia(100);
        caçador.AtribuirArmadilhas(5);
        caçador.AtribuirForcaDoArco(20);
        caçador.AtribuirVelocidade(10);
        caçador.atribuirArmadilhaDeUrso(true);

        Debug.Log("Nome: " + personagem.Nome());
        Debug.Log("Energia: " + personagem.Energia());
        Debug.Log("Velocidade: " + personagem.Velocidade());
        Debug.Log("Força de Ataque: " + personagem.ForcaAtaque());
        
        Debug.Log("Nome: " + caçador.Nome());
        Debug.Log("Energia: " + caçador.Energia());
        Debug.Log("Armadilhas: " + caçador.Armadilhas());
        Debug.Log("Força do Arco: " + caçador.ForcaDoArco());
        Debug.Log("Velocidade: " + caçador.Velocidade());
        
    }

   
    
    void Update()
    {
        
    }
}