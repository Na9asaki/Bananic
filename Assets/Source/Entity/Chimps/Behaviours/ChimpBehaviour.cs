using Assets.Source.Entity.Chimps.Behaviours.ScriptableObjects;
using System;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Source.Entity.Chimps.Behaviours
{
    [Serializable]
    internal class ChimpBehaviour
    {
        [SerializeField] private ChimpBehaviourConfiguration _configuration;
        [SerializeField] private Chimp _self;
        [SerializeField] private Transform _areaPoint;

        private Dictionary<Type, State> _states;
        private State _current;

        public void Initialize()
        {
            _states = new Dictionary<Type, State>();
            Add(new WalkState(_configuration, _self, _areaPoint.position));
        }

        public void EnterIn<T>(MonoEntity entity = null)
        {
#if UNITY_EDITOR
            if (!_states.ContainsKey(typeof(T)))
            {
                throw new ArgumentException(nameof(T));
            }
#endif
            _current?.Exit();
            _current = _states[typeof(T)];
            _current.Enter(entity);
        }

        public void Update()
        {
            _current?.Update();
        }

        public void Add(State state)
        {
            _states.Add(state.GetType(), state);
        }

        public State Get<T>() where T : State
        {
            if (_states.TryGetValue(typeof(T), out State state)) return state;
            throw new ArgumentException(nameof(T));
        }
    }
}
