using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunManager : MonoBehaviour
{
    public static GunManager instance;

    public static int gunCount = 4;
    public Gun[] guns;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void StopAllGuns()
    {
        for(int i = 0; i < guns.Length; i++)
        {
            guns[i].StopShoot();
        }
    }
}
