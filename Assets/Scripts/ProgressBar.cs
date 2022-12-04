using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar : MonoBehaviour
{
    public Image mask;
    public Transform FinishLine;
    public Transform Sprite;

    void Start()
    {
        
    }

    void Update()
    {
        GetCurrentFill();
    }

    public void GetCurrentFill()
    {
        transform.localScale = new Vector3 ((Sprite.transform.position.x + 1000f) / (FinishLine.transform.position.x + 1000f), 1, 1);
    } 
}
