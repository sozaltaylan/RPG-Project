using DG.Tweening;
using UnityEngine;
using UnityEngine.AI;


namespace Game.Controller
{

    public class PlayerController : MonoBehaviour
    {
        #region Variables

        private Vector3 _moveTarget;
        private bool _isMoving;


        #region SerializeFields 

        [SerializeField] private NavMeshAgent navMeshAgent;
        [SerializeField] private PlayerAnimationController playerAnimationController;
        [SerializeField] private PlayerSO playerSO;
        #endregion

        #endregion

        #region Methods

        private void Start()
        {
            _moveTarget = this.transform.position;
            navMeshAgent.angularSpeed = playerSO.angularSpeed;
            navMeshAgent.speed = playerSO.speed;
        }
        private void Update()
        {
            if (_isMoving)
            {
                if (Vector3.Distance(transform.position, _moveTarget) < 0.1f)
                {
                    _isMoving = false;
                    playerAnimationController.SetAnimationSpeed(0);
                }
            }
            
        }
        public void MoveToClickedPosition(Vector3 target) 
        {
            _moveTarget = target;
            navMeshAgent.SetDestination(_moveTarget);
            playerAnimationController.SetAnimationSpeed(1);
            _isMoving = true;
        }

        public void LookNPC(Transform target,bool active)
        {
            StopPlayer(active);
            playerAnimationController.SetAnimationSpeed(0);
            transform.DOLookAt(target.position, 1f);
        }

        public void StopPlayer(bool active)
        {
            navMeshAgent.isStopped = active;
        }
        #endregion


    }
}
