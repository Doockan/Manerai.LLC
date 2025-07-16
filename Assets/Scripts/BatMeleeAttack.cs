using Unity.VisualScripting;
using UnityEngine;

namespace Assets.Scripts
{
  public class BatMeleeAttack : MonoBehaviour
  {
    [SerializeField] private Animator _animator;
    public int _damage = 10;

    public void Update()
    {
      if (Input.GetButtonDown("Fire1"))
      {
        _animator.SetBool("attack", true);
      }

      if (Input.GetButtonUp("Fire1"))
      {
        _animator.SetBool("attack", false);        
      }
    }
  }
}
