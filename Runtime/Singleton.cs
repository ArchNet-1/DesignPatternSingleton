// ArchNet · Singleton
// A MonoBehaviour that exists once in the scene, reachable from anywhere with
// GameManager.Instance. A second copy destroys itself.
// Docs: https://archnet-plateform.fr/#DesignPatternSingleton

using UnityEngine;

namespace ArchNet.DesignPattern
{
    /// <summary>
    /// Base class for a scene singleton.
    /// <code>public class GameManager : Singleton&lt;GameManager&gt; { }</code>
    /// </summary>
    public abstract class Singleton<T> : MonoBehaviour where T : MonoBehaviour
    {
        [Tooltip("Keep this object when a new scene loads.")]
        [SerializeField] bool _keepBetweenScenes;

        /// <summary>The live instance, or null when none is in the scene.</summary>
        public static T Instance { get; private set; }

        public static bool HasInstance => Instance != null;

        /// <summary>When overriding, call base.Awake() first.</summary>
        protected virtual void Awake()
        {
            if (Instance != null && Instance != this)
            {
                Debug.LogWarning($"[ArchNet] A second {typeof(T).Name} was found on '{name}' and destroyed.", this);
                Destroy(gameObject);
                return;
            }
            Instance = this as T;
            if (_keepBetweenScenes)
            {
                transform.SetParent(null); // DontDestroyOnLoad only works on root objects
                DontDestroyOnLoad(gameObject);
            }
        }

        protected virtual void OnDestroy()
        {
            if (Instance == this) Instance = null;
        }
    }
}
