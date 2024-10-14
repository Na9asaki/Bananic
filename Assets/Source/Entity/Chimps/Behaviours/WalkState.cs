using Assets.Source.Entity.Chimps.Behaviours.ScriptableObjects;
using UnityEngine;

namespace Assets.Source.Entity.Chimps.Behaviours
{
    internal class WalkState : State
    {
        private readonly Vector3 _startPoint;
        protected readonly Transform _transform;

        private Vector3 _nextPoint;
        private float _timeToMove;

        public WalkState(ChimpBehaviourConfiguration configuration, Chimp chimp, Vector3 startPoint) : base(chimp, configuration)
        {
            _startPoint = startPoint;
            _transform = chimp.transform;
        }

        private void ChangeNextPoint()
        {
            Vector2 insideUnityCircleRandomPoint = Random.insideUnitCircle * _configuration.ChimpsAreaRadius;
            Vector3 insideUnitCircleIn3 = new Vector3(insideUnityCircleRandomPoint.x, _transform.position.y, insideUnityCircleRandomPoint.y);
            _nextPoint = insideUnitCircleIn3 + _startPoint;
        }

        public override void Enter(MonoEntity entity)
        {
            ChangeNextPoint();
        }

        public override void Exit()
        {

        }

        public override void Update()
        {
            if (_transform.position == _nextPoint)
            {
                _timeToMove = Time.time + _configuration.WaitingTime;
                ChangeNextPoint();
            }
            if (Time.time >  _timeToMove)
            {
                _transform.LookAt(_nextPoint);
                _transform.position = Vector3.MoveTowards(_transform.position, _nextPoint, _configuration.WalkSpeed * Time.deltaTime);
            }
        }
    }
}
