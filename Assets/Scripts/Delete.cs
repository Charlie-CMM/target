using UnityEngine;

public class Delete : MonoBehaviour
{
    public GameObject target;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Bullet")
        {
            GameObject.Find("Wall").GetComponent<Score>().updateScore(10); //из объекта берем скрип и отсылаемся к ф-ции скрипта 
            Instantiate(target, new Vector3(Random.Range(-2.5f, 2.5f), 1.68f, target.transform.position.z + 20f), Quaternion.identity); //рандомный спавн объекта
            Destroy(gameObject); //удаление объекта при столкновении
        }   
    }
}
