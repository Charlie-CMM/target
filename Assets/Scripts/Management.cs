using UnityEngine;
using UnityEngine.UI;

public class Management : MonoBehaviour
{
    public GameObject Bullet;
    private float speed = 3f;
    private float bulletsSpeed = 0.0005f;
    private bool isShoot = false;
    private float finalposition = 100f;


    void Update()
    {    
        float stepX = Input.GetAxis("Horizontal") * speed;  // �������������� ��������      
        float stepY = Input.GetAxis("Vertical") * speed;  // ������������ �������� 
        Vector3 moveVector = new Vector3(stepX, stepY, 0); //��������� ��������� ������� 

        Bullet.transform.Translate(moveVector * Time.deltaTime); //��� �������� ������� 

        if (Input.GetMouseButton(0)) //��������, ��� �� ������ ����
        {
            isShoot = true;
        }

        if (isShoot)
        {
            transform.position = Vector3.Lerp(transform.position, new Vector3(Bullet.transform.position.x, Bullet.transform.position.y, finalposition), bulletsSpeed); 

            if (Bullet.transform.position.z > 0) 
            {
                finalposition = 100f + Bullet.transform.position.z; //����������� �������� 
            }           
        }
    }
}
