using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Socialize.Share.RNSocializeShare
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNSocializeShareModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNSocializeShareModule"/>.
        /// </summary>
        internal RNSocializeShareModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNSocializeShare";
            }
        }
    }
}
