using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubenotes : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
public class box : cubenotes
{
    public int pos;
    int next;
    int position(int p)
    {
        if (p > 5)
        {
            pos = p % 6;

        }
        else
            pos = p;
    }
    void note (int s)
    {
        switch(s)
        {
            case 0:

                break;
            case 1:

                break;
            case 2:

                break;
            case 3:

                break;
            case 4:

                break;
            case 5:

                break;
            case 6:

                break;
            case 7:

                break;
            case 8:

                break;
            case 9:

                break;
            case 10:

                break;
            case 11:

                break;
            
            default:
                break;
        }

        if () { }
    }
}
