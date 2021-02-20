using UnityEngine;

namespace ArchNet.Design.Pattern.Singleton
{
    /// <summary>
    /// [MODULE] - [ARCH NET] - [DESIGN PATTERN] - Singleton
    /// author : LOUIS PAKEL
    /// </summary>
    public class Singleton<T> : MonoBehaviour where T : MonoBehaviour
    {
        #region Property

        // Property used to get the instance of this singleton
        public static T Instance { get { return _instance; } }

        #endregion

        #region Fields

        // Contains the instance of this singleton
        private static T _instance = null;

        #endregion

        #region Protected Methods

        /// <summary>
        /// Monobehaviour method called to set the instance of the singleton
        /// </summary>
        protected virtual void Awake()
        {
            if (null != _instance)
            {
                Destroy(this.gameObject);
            }
            else
            {
                _instance = this as T;
            }
        }

        /// <summary>
        /// Monoebehaviour method called when destroy this object
        /// </summary>
        protected virtual void OnDestroy()
        {
            if (this == _instance)
            {
                _instance = null;
            }
        }

        #endregion  
    }

}