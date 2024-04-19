using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateUImenu : MonoBehaviour
{

    public GameObject botones;
    public GameObject botones1;
    public GameObject botones2;
    public GameObject botones3;
    public GameObject botones4;
    public GameObject Logo;
    public GameObject tutorial;
    public GameObject Ranking;
    public GameObject Game;
    public GameObject tienda;
    public GameObject Perfil;
    public GameObject Noticia;



    public void ActivaBotones()
    {
        LeanTween.moveX(botones.GetComponent<RectTransform>(), -484f, 3f)
            .setEase(LeanTweenType.easeInOutElastic);
    }
    public void ActivaBotones1()
    {
        LeanTween.moveX(botones1.GetComponent<RectTransform>(), -484f, 3f)
            .setEase(LeanTweenType.easeInOutElastic);
    }
    public void ActivaBotones2()
    { 
        LeanTween.moveX(botones2.GetComponent<RectTransform>(), -484f, 3f)
           .setEase(LeanTweenType.easeInOutElastic);
    }
    public void ActivaBotones3()
    {
        LeanTween.moveX(botones3.GetComponent<RectTransform>(), -484f, 3f)
           .setEase(LeanTweenType.easeInOutElastic);
    }
    public void ActivaBotones4()
    { 
        LeanTween.moveX(botones4.GetComponent<RectTransform>(), -484f, 3f)
           .setEase(LeanTweenType.easeInOutElastic);
    }
    private void Start()
    {
        LeanTween.moveY(Logo.GetComponent<RectTransform>(), 239, 1.3f).setEase(LeanTweenType.easeOutBounce)
            .setDelay(0.3f);
        LeanTween.moveY(tutorial.GetComponent<RectTransform>(), -401, 1.5f).setEase(LeanTweenType.easeInOutQuad)
           .setDelay(0.6f);
        LeanTween.moveY(Ranking.GetComponent<RectTransform>(), -394, 1.5f).setEase(LeanTweenType.easeInOutQuad)
           .setDelay(0.6f); 
        LeanTween.moveY(Game.GetComponent<RectTransform>(), -370, 1.3f).setEase(LeanTweenType.easeInOutQuad)
           .setDelay(0.4f); 
        LeanTween.moveY(tienda.GetComponent<RectTransform>(), -396, 1.3f).setEase(LeanTweenType.easeInOutQuad)
               .setDelay(0.5f); 
        LeanTween.moveY(Perfil.GetComponent<RectTransform>(), 494, 1.3f).setEase(LeanTweenType.easeInOutQuad)
           .setDelay(0.5f);
        LeanTween.moveX(Noticia.GetComponent<RectTransform>(), 1002, 1.6f).setEase(LeanTweenType.easeInOutQuad)
           .setDelay(0.7f);

    }
}