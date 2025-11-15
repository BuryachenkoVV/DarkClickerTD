using Assets._Scripts;
using UnityEngine;
using UnityEngine.EventSystems;

public class Projectile : MonoBehaviour
{
    public float speed = 10f;
    private Transform target;
    private float damage;
    private DamageType damageType;

    /// <summary>
    /// Создает снаряд
    /// </summary>
    /// <param name="target">Цель</param>
    /// <param name="damage">Величина урона</param>
    /// <param name="type">Тип урона</param>
    public void Initialize(Transform target, float damage, DamageType type)
    {
        this.target = target;
        this.damage = damage;
        this.damageType = type;
    }

    void Update()
    {
        if (target == null)
        {
            Destroy(gameObject); // Уничтожить снаряд, если цель исчезла
            return;
        }

        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        //transform.position += moveDirection * speed * Time.deltaTime;

        if (Vector3.Distance(transform.position, target.position) < 0.5f)
        {
            HitTarget();
        }
    }

    void HitTarget()
    {
        Enemy enemy = target.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage, damageType);
        }
        Destroy(gameObject); // Уничтожить снаряд после попадания
    }
}
