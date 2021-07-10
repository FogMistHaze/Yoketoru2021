using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SETest : MonoBehaviour
{
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            TinyAudio.PlaySE(TinyAudio.SE.Menu_ugoki);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            TinyAudio.PlaySE(TinyAudio.SE.Menu_UP);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            TinyAudio.PlaySE(TinyAudio.SE.Kettei);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            TinyAudio.PlaySE(TinyAudio.SE.Cancel);
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            TinyAudio.PlaySE(TinyAudio.SE.Attack_niku);
        }
        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            TinyAudio.PlaySE(TinyAudio.SE.Attack_tomato);
        }
    }
}
