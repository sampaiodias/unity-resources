using NUnit.Framework;
using System.Collections;
using UnityEngine;
using UnityEngine.TestTools;

namespace SampaioDias.SolidItemSystem.Tests
{
    public class ProjectileTests
    {
        [UnityTest]
        public IEnumerator WhenUnityUpdates_ThenProjectileMoves()
        {
            Projectile p = new GameObject().AddComponent<Projectile>();
            p.transform.position = Vector3.zero;
            p.transform.rotation = Quaternion.identity;
            p.speed = 1000;
            yield return null;
            Assert.IsTrue(p.transform.position.z > 0);
        }
    }
}
