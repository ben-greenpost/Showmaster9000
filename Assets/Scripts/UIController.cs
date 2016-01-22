using UnityEngine;
using System.Collections;

public class UIController : MonoBehaviour
{
    public GameObject panelBlack;
    public GameObject panelSelection;

<<<<<<< HEAD
    void Start()
    {
        panelGlowingEye.transform.SetAsLastSibling();
        panelSelection.GetComponent<CanvasGroup>().alpha = 0;
        panelBlack.GetComponent<CanvasGroup>().alpha = 0;
    }

    public void FadeTo(GameObject panel)
=======
    public void FadeTo(string panel)
>>>>>>> parent of 5588c27... New Fade-In logic
    {
        if(panel == "Selection")
        {
            panelBlack.SetActive(true);
            StartCoroutine(DoFade());
        }
    }

    IEnumerator DoFade()
    {
<<<<<<< HEAD
        yield return new WaitForSeconds(0.3f);

        panel.GetComponent<CanvasGroup>().alpha = 0;
        panel.transform.SetAsLastSibling();
        StartCoroutine(panel.GetComponent<FadeIn>().DoFade());

        // Reset black panel alpha
        //yield return new WaitForSeconds(2);
=======
        yield return new WaitForSeconds(2);
        panelSelection.SetActive(true);
>>>>>>> parent of 5588c27... New Fade-In logic
    }
}
