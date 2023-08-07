using UnityEngine;
using DG.Tweening;


namespace Game.Controller
{
    public class PlayerAnimationController : MonoBehaviour
    {
        #region Variables

        [SerializeField] private Animator anim;

        #endregion

        public void SetAnimationSpeed(float animationSpeed)
        {

            float currentSpeed = anim.GetFloat("MoveSpeed");
            if (currentSpeed == animationSpeed) return;
            DOVirtual.Float(currentSpeed, animationSpeed, .5f, SetAnimSpeed);

        }
        private void SetAnimSpeed(float x)
        {
                anim.SetFloat("MoveSpeed", x);

        }
    }
}
