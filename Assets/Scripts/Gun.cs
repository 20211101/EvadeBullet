using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public Transform target;
    float shootTime = 3;
    float curTime = 0;
    bool canShoot = true;

    public GameObject bullet;

    // 자기 자신이 발사를 멈춤
    public void StopShoot()
    {
        canShoot = false; 
    }    

    // GM 에게 정지 명령을 보내기
    public void SendStopMessage()
    {
        GunManager.instance.StopAllGuns();
    }

    void Update()
    {
        if (canShoot == false)
        {
            return;
        }
        curTime += Time.deltaTime;// cur 1초 후 - 1 2초 후 - 2

        if(curTime >= shootTime)
        {
            GameObject bul = Instantiate(bullet, transform.position, Quaternion.identity);
            // 총알 발사 방향 컨트롤
            Bullet bulComp =  bul.GetComponent<Bullet>();
            Vector3 dir = (target.position - transform.position).normalized;
            bulComp.Init(dir, this);
            
            // 타이머 초기화
            curTime = 0;
            shootTime = Random.Range(1, 4); // 1, 2, 3 부터, 4 전 까지
        }
    }
}
