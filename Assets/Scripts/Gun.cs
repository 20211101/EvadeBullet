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

    // �ڱ� �ڽ��� �߻縦 ����
    public void StopShoot()
    {
        canShoot = false; 
    }    

    // GM ���� ���� ����� ������
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
        curTime += Time.deltaTime;// cur 1�� �� - 1 2�� �� - 2

        if(curTime >= shootTime)
        {
            GameObject bul = Instantiate(bullet, transform.position, Quaternion.identity);
            // �Ѿ� �߻� ���� ��Ʈ��
            Bullet bulComp =  bul.GetComponent<Bullet>();
            Vector3 dir = (target.position - transform.position).normalized;
            bulComp.Init(dir, this);
            
            // Ÿ�̸� �ʱ�ȭ
            curTime = 0;
            shootTime = Random.Range(1, 4); // 1, 2, 3 ����, 4 �� ����
        }
    }
}
