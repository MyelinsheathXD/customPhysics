using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jusangtorad : MonoBehaviour
{
    // Start is called before the first frame update
    [Range(-360, 360)]
    public float INangle, OUTangle, cona,theangecoll;

    public float cha, chb;
    // Update is called once per frame
    void Update()
    {
        Vector3 tVV=new Vector3();


        float ca = Mathf.Cos(INangle * Mathf.PI / 180);
        float sa = Mathf.Sin(INangle * Mathf.PI / 180);

        cha = Vector2.SignedAngle( new Vector2(1, 0), new Vector2(ca, sa));

        float cb = Mathf.Cos(theangecoll * Mathf.PI / 180);
        float sb = Mathf.Sin(theangecoll * Mathf.PI / 180);

        chb = Vector2.SignedAngle( new Vector2(1, 0), new Vector2(cb, sb));

        OUTangle = 2 * chb - cha;

        /*float T = cb * cb + sb * sb;
        float Q = 2 * sb * cb;

        tVV.x = T * ca + Q * sa;
        tVV.y = Q * ca - T * sa;*/

        tVV.x = Mathf.Cos(OUTangle * Mathf.PI / 180);
        tVV.y = Mathf.Sin(OUTangle * Mathf.PI / 180);


        Vector2 aa = new Vector2(tVV.x, tVV.y);
        Vector2 bb = new Vector2(1, 0);
        cona = Vector2.SignedAngle(bb,aa);

        //OUTangle = Mathf.Acos(tVV.x) * 180 / Mathf.PI;
    }
}
