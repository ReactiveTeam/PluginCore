using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginCore
{
    /// <summary>
    /// Plugin interface. Implement this in your class to allow it to be detected by the plugin manager.
    /// </summary>
    public interface IPlugin
    {
        #region Module Info
        /// <summary>
        /// The modules name
        /// </summary>
        string pluginName { get; }

        /// <summary>
        /// The modules description
        /// </summary>
        string pluginDescription { get; }

        /// <summary>
        /// The modules author
        /// </summary>
        string pluginAuthor { get; }
        #endregion

        /// <summary>
        /// Runs anything at the start of the program
        /// </summary>
        void Start();

        /// <summary>
        /// Runs anything at the end of the program or when the module is unloaded
        /// </summary>
        void Stop();

        /// <summary>
        /// Runs anything in a loop
        /// </summary>
        void Tick();
    }
}
