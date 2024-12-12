using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[System.Serializable]
public class PersonagemRender
{
    public Image corpo;
    public Image pele;
    public Image olhos;
    public Image orelhas;
    public Image efeito;
    public Image pernas;
    public Image bracos;

    public void Renderizar(Personagem propiedades){
        // sprites
        pele.sprite = propiedades.peles[propiedades.pele].sprite;
        orelhas.sprite = propiedades.orelhas[propiedades.orelha].sprite;
        efeito.sprite = propiedades.efeitos[propiedades.efeito].sprite;
        // cores
        corpo.color = propiedades.cores_disponiveis[propiedades.cor_corpo];
        pele.color = propiedades.cores_disponiveis[propiedades.cor_pele];
        olhos.color = propiedades.cores_disponiveis[propiedades.cor_olhos];
        orelhas.color = propiedades.cores_disponiveis[propiedades.cor_orelha];
        efeito.color = propiedades.cores_disponiveis[propiedades.cor_efeito];
        pernas.color = propiedades.cores_disponiveis[propiedades.cor_pernas];
        bracos.color = propiedades.cores_disponiveis[propiedades.cor_bracos];
    }
}