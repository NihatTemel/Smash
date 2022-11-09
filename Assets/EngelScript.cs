using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class EngelScript : MonoBehaviour
{

    [SerializeField] bool Spatula;
    [SerializeField] bool Pervane;
    [SerializeField] bool Rotate;
    [SerializeField] bool MoveLoop;

    [SerializeField] float RotateSpeed;
    [SerializeField] float MoveSpeed;
    [SerializeField] float SpatulaRotateSpeed;
    [SerializeField] float SpatulaRotateAngle;



    
    void Start()
    {
        if (Spatula) 
        {
            InvokeRepeating("SpatulaMove", 0, 41414);
            //SpatuleMove();
        }
        if (MoveLoop) 
        {
            MoveYoyo();
        }
    }

   
    void PervaneRotate() 
    {
        transform.Rotate(RotateSpeed, 0, 0);
    }

    void SpatulaMove() 
    {
        transform.DORotate(new Vector3(-90, 0, SpatulaRotateAngle), SpatulaRotateSpeed,RotateMode.Fast).SetLoops(999,LoopType.Yoyo);
        //SpatulaRotateSpeed *= -1;
        if (SpatulaRotateAngle > 0) 
        {

            //SpatulaRotateAngle = 0;

        }
        else 
        {
           // SpatulaRotateAngle = 180;
        }
    }


    void MoveYoyo() 
    {
        transform.DOMove(transform.GetChild(1).transform.position, MoveSpeed).SetLoops(999, LoopType.Yoyo);
    }


    void FixedUpdate()
    {
        if (Pervane) 
        {
            PervaneRotate();
        }
        else if (Spatula) 
        {
           
        }
    }
}
