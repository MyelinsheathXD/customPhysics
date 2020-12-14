using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bouncequad : MonoBehaviour
{
    public Vector3 VV;
    public float MM, RR, alpha1;

    [Range(-360, 360)]
    public float INangle, OUTangle,theangecoll;
   

    


    void Update()
    {


            Vector3 tVV = VV.normalized;

        float ca = Mathf.Cos(INangle * Mathf.PI / 180);
        float sa = Mathf.Sin(INangle * Mathf.PI / 180);





        float cb = Mathf.Cos(theangecoll * Mathf.PI / 180);
            float sb = Mathf.Sin(theangecoll * Mathf.PI / 180);

            float L1 = Mathf.Sqrt((ca - cb) * (ca - cb) + (sa - sb) * (sa - sb));
            float L2 = Mathf.Sqrt((ca + cb) * (ca + cb) + (sa + sb) * (sa + sb));

            

            float T = cb * cb + sb * sb;
            float Q = 2 * sb * cb;

            tVV.x = T * ca + Q * sa;
            tVV.y = Q * ca - T * sa;



            float aa = Mathf.Abs(VV.x);
            float bb = Mathf.Abs(VV.y);


        OUTangle= Mathf.Acos(tVV.x)*180/Mathf.PI;     

            VV.x = tVV.x ;
            VV.y = tVV.y ;




        


    }
}
