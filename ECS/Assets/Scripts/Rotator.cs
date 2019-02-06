using Unity.Entities;
using UnityEngine;

namespace Assets.Scripts
{
    public class Rotator : MonoBehaviour
    {
        public float Speed;
    }

    public class RotatorSystem : ComponentSystem
    {
        private struct Components
        {
            public Rotator rotator;
            public Transform transform;
        }

        protected override void OnUpdate()
        {
            var deltaTime = Time.deltaTime;
            foreach (var entity in GetEntities<Components>())
            {
                entity.transform.Rotate(0f, entity.rotator.Speed * deltaTime, 0f);
            }
        }
    }
}