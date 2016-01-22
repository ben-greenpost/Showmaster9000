using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class FadeInOut : MonoBehaviour 
{
	public Animator animator;
    public GameObject PanelSelection;

	public void FadeOut()
	{
		StartCoroutine (DoFade ("out"));
	}

	public void FadeIn()
	{
		StartCoroutine (DoFade ("in"));
	}

	IEnumerator DoFade(string typ)
	{
		CanvasGroup cg = GetComponent<CanvasGroup> ();

		if (typ == "out") 
		{
			while(cg.alpha > 0)
			{
				cg.alpha -= Time.deltaTime / 2;
				yield return null;
			}
		}

		if (typ == "in") 
		{
			while(cg.alpha < 1)
			{
				cg.alpha += Time.deltaTime / 2;
				yield return null;
			}

			//Stop glowing animation
			animator.Stop ();
            PanelSelection.SetActive(true);
		}

		yield return null;
	}

	IEnumerator DoFadeIn()
	{
		CanvasGroup cg = GetComponent<CanvasGroup> ();

		while(cg.alpha < 1)
		{
			Debug.Log ("while()");
			cg.alpha += Time.deltaTime / 2;
			yield return null;
		}

		yield return null;
	}
}
