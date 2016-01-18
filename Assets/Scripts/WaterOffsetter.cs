using UnityEngine;
using System.Collections;

public class WaterOffsetter : MonoBehaviour
{

    [SerializeField]
    private Material waterMat;

    private float amplitude = 0.1f;
    private float min = 0.9f;
    private float frequency = 15f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update ()
	{
	    float value = (Mathf.Sin(Time.timeSinceLevelLoad*frequency) + 1 + min);
	    value /= (1/amplitude);
	    waterMat.SetFloat("_DetailNormalMapScale", value);
        waterMat.SetFloat("_Cutoff", (Mathf.Sin(0.5f*Time.timeSinceLevelLoad)+0.9f)/2);
	}
}
