using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Diagnostics;
using System;

public class GameManager : MonoBehaviour
{
    public int pontuacaoDoJogador1;
    public int pontuacaoDoJogador2;
    public Text textoDePontuacao;
    public int set1;
    public int set2;
    public Text setE;
    public Text setD;
    public Text TextFinal;
    public AudioSource somDoGol;
    public int gameEnd = 20;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
            
        }

    }

    public void AumentarPontuacaoDoJogador1()
    {
        pontuacaoDoJogador1 += 1;
        AtualizarTextoDePontuacao();
    }
    public void AumentarPontuacaoDoJogador2()
    {
        pontuacaoDoJogador2 += 1;
        AtualizarTextoDePontuacao();
    }


    
    public void AtualizarTextoDePontuacao()
    {
        verificarSets();
        setD.text = countSets(set2);
        setE.text = countSets(set1);
        textoDePontuacao.text = pontuacaoDoJogador1 + " X " + pontuacaoDoJogador2;
        somDoGol.Play(); //inclusão do som
        verificarFim();
    }

    public void verificarSets()
    {
        if(pontuacaoDoJogador1 == gameEnd - 1 && pontuacaoDoJogador2 == gameEnd - 1)
        {
            gameEnd += 1;
        }
        else if(pontuacaoDoJogador1 == gameEnd)
        {
            pontuacaoDoJogador1 = 0;
            pontuacaoDoJogador2 = 0;
            set1 += 1;
        }
        else if (pontuacaoDoJogador2 == gameEnd)
        {
            pontuacaoDoJogador1 = 0;
            pontuacaoDoJogador2 = 0;
            set2 += 1;
        }

    }

    public void verificarFim()
    {
        if(set1 == 3)
        {
            TextFinal.text = "jogador 1 vence";
        }
        else if (set2 == 3)
        {
            TextFinal.text = "jogador 2 vence";
        }
        
    }

    public string countSets(int num)
    {

        string str = "";

        for(int i = 0; i < num; i++)
        {
            str += "1";
        }

        return str;
    }



}
