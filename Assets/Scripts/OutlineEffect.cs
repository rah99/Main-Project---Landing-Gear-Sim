using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OutlineEffect : MonoBehaviour
{
    public Material mat;
    public float thickness = 1.03f;
    [ColorUsage(true, true)]
    public Color colorOutline;
    private Renderer rend;

    void Start()
    {
        GameObject outlineObject = Instantiate(this.gameObject, transform.position, transform.rotation, transform);
        outlineObject.transform.localScale = new Vector3(1, 1, 1);
        Renderer rend = outlineObject.GetComponent<Renderer>();

        rend.material = mat;
        rend.material.SetColor("_OutlineColor", colorOutline);
        rend.material.SetFloat("_Thickness", thickness);
        rend.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.Off;

        outlineObject.GetComponent<OutlineEffect>().enabled = false;
        //outlineObject.GetComponent<Collider>().enabled = false;

        rend.enabled = false;

        this.rend = rend;
    }

    //private void OnMouseExit()
    //{
    //    rend.enabled = false;
    //}

    //private void OnMouseEnter()
    //{
    //    rend.enabled = true;
    //}
}
