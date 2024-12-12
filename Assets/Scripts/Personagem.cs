using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class Personagem
{
    public string nome;
    public List<Color> cores_disponiveis;
    public List<Pele> peles;
    public List<Orelha> orelhas;
    public List<Efeito> efeitos;
    public int cor_corpo;
    public int pele;
    public int cor_pele;
    public int orelha;
    public int cor_orelha;
    public int efeito;
    public int cor_efeito;
    public int cor_olhos;
    public int cor_pernas;
    public int cor_bracos;

    public void SetCor(string local, int cor){
        if(local == "corpo") this.cor_corpo = cor;
        else if(local == "pele") this.cor_pele = cor;
        else if(local == "olhos") this.cor_olhos = cor;
        else if(local == "orelhas") this.cor_orelha = cor;
        else if(local == "efeito") this.cor_efeito = cor;
        else if(local == "bracos") this.cor_bracos = cor;
        else if(local == "pernas") this.cor_pernas = cor;
    }

    public string NomePele(){
        return this.peles[this.pele].nome;
    }
    public string NomeOrelha(){
        return this.orelhas[this.orelha].nome;
    }
    public string NomeEfeito(){
        return this.efeitos[this.efeito].nome;
    }
}