using UnityEngine;
using System.Collections;

public class RainHud : MonoBehaviour
{

    [SerializeField]
    private MovieTexture rainMovie;


	// Use this for initialization
	void Start ()
	{
	    gameObject.GetComponent<Renderer>().material.mainTexture = rainMovie as MovieTexture;
        rainMovie.loop = true;
        rainMovie.Play();
	    
	}
	
	
}
