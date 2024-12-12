using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class EditorController : MonoBehaviour
{
    [Header("PERSONAGEM")]
    [SerializeField] private Personagem _propiedades;
    [SerializeField] private PersonagemRender personagem;

    [Header("HUD PERSONAGEM")]
    [SerializeField] private TMP_Text NomeNaTela;

    [Header("OPÇÕES")]
    [SerializeField] private Text PeleSelecionada;
    [SerializeField] private Text OrelhaSelecionada;
    [SerializeField] private Text EfeitoSelecionado;


    void Update(){
        if(_propiedades.nome != "") NomeNaTela.text = _propiedades.nome;
        else NomeNaTela.text = "Nome do Personagem";
        PeleSelecionada.text = _propiedades.NomePele();
        OrelhaSelecionada.text = _propiedades.NomeOrelha();
        EfeitoSelecionado.text = _propiedades.NomeEfeito();
        personagem.Renderizar(_propiedades);
    }

    GameObject PegarSeletor(Transform objeto_pai){
        for(int i = 0; i < 14; i++){
            Transform cor = objeto_pai.GetChild(i);
            if(cor.childCount > 0){
                return cor.GetChild(0).gameObject;
            }
        }
        return new GameObject();
    }

    int PegarIndiceCor(Transform objeto_cores){
        for(int i = 0; i < 14; i++){
            Transform cor = objeto_cores.GetChild(i);
            if(cor.childCount > 0){
                return i;
            }
        }
        return 0;
    }

    public void CorSelecionada(Button clicado){
        Transform cores = clicado.transform.parent;
        string local = cores.gameObject.tag;
        GameObject Seletor =  PegarSeletor(cores);
        Seletor.GetComponent<RectTransform>().SetParent(clicado.transform);
        Seletor.GetComponent<RectTransform>().localPosition = new Vector3(0, 0, 0);
        int cor = PegarIndiceCor(cores);
        _propiedades.SetCor(local, cor);
    }

    // função que é chamada ao finalizar a edição do input;
    public void ChangeName(string nome){
        _propiedades.nome = nome;
    }
    public void MudarPele(int direcao){
        if(direcao == -1 && _propiedades.pele == 0) _propiedades.pele += _propiedades.peles.Count-1;
        else if(direcao == 1 && _propiedades.pele == _propiedades.peles.Count-1) _propiedades.pele = 0;
        else _propiedades.pele += direcao;
    }
    public void MudarOrelha(int direcao){
        if(direcao == -1 && _propiedades.orelha == 0) _propiedades.orelha += _propiedades.orelhas.Count-1;
        else if(direcao == 1 && _propiedades.orelha == _propiedades.orelhas.Count-1) _propiedades.orelha = 0;
        else _propiedades.orelha += direcao;
    }
    public void MudarEfeito(int direcao){
        if(direcao == -1 && _propiedades.efeito == 0) _propiedades.efeito += _propiedades.efeitos.Count-1;
        else if(direcao == 1 && _propiedades.efeito == _propiedades.efeitos.Count-1) _propiedades.efeito = 0;
        else _propiedades.efeito += direcao;
    }
}
