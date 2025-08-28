using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using Unity.Cinemachine;

public class Menu : MonoBehaviour
{
    public CanvasGroup fade;
    public float duracaoFade = 1.5f;
    public CinemachineSplineCart trem;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        fade.alpha = 1;
        fade.blocksRaycasts = false;
        trem.AutomaticDolly.Enabled = false;
        Debug.Log("Inicio!");
    }

    public void InicioDeJogo(){
        Debug.Log("Entrou na função IniciarDeJogo");
        StartCoroutine(InicioFadeOut());
    }

    IEnumerator InicioFadeOut() {
        Debug.Log("Entrou na segunda função");
        fade.blocksRaycasts = true;

        float i = 0f;
        while(i < duracaoFade) {
            i += Time.deltaTime;
            fade.alpha = Mathf.Lerp(1f, 0f, i / duracaoFade);
            yield return null;
        }

        trem.AutomaticDolly.Enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
