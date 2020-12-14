using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spherecol : MonoBehaviour
{

    public Vector3 VV, AA, FF,gG;
    public float MM, RR, alpha1;

    [Range(0, 180)]
    public float theangecoll;
    bool touch = false;
    
    void Start()
    {
        RR *=transform.localScale.y;
    }

    
    void Update()
    {

        float dtt = Time.deltaTime;




        AA = FF/MM+gG;
        VV += AA * dtt;


        if (transform.position.y-RR<0&&!touch)
        {
            touch = true;

            Vector3 tVV = VV.normalized;

            float ca = tVV.x;
            float sa = tVV.y;
            /*ca *= -1;
            sa *= -1;*/

            


            float taa =Mathf.Abs( tVV.x);
            float tbb =Mathf.Abs( tVV.y);

            float cb = Mathf.Cos(theangecoll * Mathf.PI / 180);
            float sb = Mathf.Sin(theangecoll * Mathf.PI / 180);

            float L1 = Mathf.Sqrt((ca - cb) * (ca - cb) + (sa - sb) * (sa - sb));
            float L2 = Mathf.Sqrt((ca + cb) * (ca + cb) + (sa + sb) * (sa + sb));

            if (L1<(0.3*0.3+0.7*0.7))
            {
                ca *= -1;
                sa *= -1;
            }

            /* if ((sa -sb)<0.707f)
             {
                 ca *= -1;
                 sa *= -1;
             }*/

            /* if (L2>L1)
             {
                  ca *= -1;
                  sa *= -1;
                  *//*cb *= -1;
                  sb *= -1;*//*

             }*/

            float T = cb * cb + sb * sb;
            float Q = 2 * sb * cb;

            tVV.x = T * ca + Q * sa;
            tVV.y= Q* ca - T* sa;



            float aa = Mathf.Abs( VV.x);
            float bb = Mathf.Abs(VV.y);
            

            float scale = (aa + bb) / (taa + tbb);

            VV.x = tVV.x * scale;
            VV.y = tVV.y * scale;




            //VV *=-1f;

            /*alpha1 = Mathf.Atan(VV.y / VV.x);
            float kn = Mathf.Tan(90 - alpha1);
            float x = Mathf.Sqrt(VV.x * VV.x + VV.y * VV.y - (kn + 1) * (kn + 1));
            float y = kn * x;*/



            //VV.y *= -1;
            //VV.y =300f;
            /*if (VV.y > 0)
            {
                VV.y *= -1;

            }
            if (VV.y < 0)
            {
                //VV.y = y;
            }*/
            //VV.x = x;
            //AA = Vector3.zero;
            VV *= 0.95f;
            
        }
        if (transform.position.y-RR>0)
        {
            touch = false;
        }

        transform.position += VV * dtt;


    }
}
