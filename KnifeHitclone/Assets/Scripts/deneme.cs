using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class deneme : MonoBehaviour
{
    public Transform go;
    void Start()
    {
        go.DORotate(new Vector3(0,0,360),2*0.5f,RotateMode.FastBeyond360).SetLoops(-1,LoopType.Restart).SetEase(Ease.Linear);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
