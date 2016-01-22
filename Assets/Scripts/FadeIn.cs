using UnityEngine;
using System.Collections;

public class FadeIn : MonoBehaviour
{
    public void Start()
    {
        StartCoroutine(DoFade());
    }

    IEnumerator DoFade()
    {
        CanvasGroup cg = GetComponent<CanvasGroup>();

        float oldT = Time.time;

        while (cg.alpha < 1)
        {
<<<<<<< HEAD
            cg.alpha += Time.deltaTime * 3;
=======
            Debug.Log("while()");
            cg.alpha += Time.deltaTime / 2;
>>>>>>> parent of 5588c27... New Fade-In logic
            yield return null;
        }
        
        Debug.Log("Time for fade: " + (Time.time - oldT));
        yield return null;
    }

}
