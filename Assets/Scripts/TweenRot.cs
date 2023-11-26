using System.Collections;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class TweenZoom : MonoBehaviour
{

    [SerializeField]
    private Image imgZoom;
    [SerializeField]
    private bool liberaZoom = true;
    [SerializeField]
    private float zoomInScale = 1.5f; // Escala para o zoom in
    [SerializeField]
    private float zoomDuration = 1f; // Duração do zoom

    void Start()
    {
        StartCoroutine(ZoomInOut());
    }

    IEnumerator ZoomInOut()
    {
        while (liberaZoom)
        {
            // Zoom in
            imgZoom.rectTransform.DOScale(zoomInScale, zoomDuration);
            yield return new WaitForSeconds(zoomDuration);

            // Zoom out
            imgZoom.rectTransform.DOScale(1f, zoomDuration);
            yield return new WaitForSeconds(zoomDuration);
        }
    }
}
