using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class Tween_Img : MonoBehaviour
{
    public RectTransform imagemRect = null;
    public Image imagemSr = null;


    [SerializeField]
    private float velF, velS;
    [SerializeField]
    private bool fade, scale;



    // Use this for initialization
    void Start()
    {



    }

    // Update is called once per frame
    void Update()
    {

        AnimacaoScala(velF, velS, fade, scale);
    }

    void AnimacaoScala(float velf, float vels, bool fade, bool scale)
    {
        if (scale)
        {
            if (imagemRect.localScale.x == 1)
            {
                imagemRect.DOScale(new Vector3(1.5f, 1.5f, 1.5f), velS);
            }
            else if (imagemRect.localScale.x == 1.5f)
            {
                imagemRect.DOScale(new Vector3(1f, 1f, 1f), velS);
            }
        }

        if (fade)
        {
            if (imagemSr.color.a == 1)
            {
                imagemSr.DOFade(0, velF);
            }
            else if (imagemSr.color.a == 0)
            {
                imagemSr.DOFade(1, velF);
            }
        }


    }

}
