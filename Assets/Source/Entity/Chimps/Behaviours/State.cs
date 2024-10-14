using Assets.Source.Entity.Chimps.Behaviours.ScriptableObjects;

namespace Assets.Source.Entity.Chimps.Behaviours
{
    internal abstract class State
    {
        protected readonly Chimp _chimp;
        protected readonly ChimpBehaviourConfiguration _configuration;

        public State(Chimp chimp, ChimpBehaviourConfiguration configuration)
        {
            _chimp = chimp;
            _configuration = configuration;
        }

        public abstract void Enter(MonoEntity entity);
        public abstract void Update();
        public abstract void Exit();
    }
}
