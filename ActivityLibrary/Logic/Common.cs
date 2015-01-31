using System.Activities;
using Microsoft.VisualBasic.Activities;
using SharedLibrary;

namespace ActivityLibrary.Logic
{
    internal class Common
    {
        /// <summary>
        /// Adds a setting to the activity provided which ensures visual basic-style declarations are interpreted correctly 
        /// </summary>
        internal static void AddVbSetting(Activity activity)
        {
            var settings = new VisualBasicSettings
            {
                ImportReferences =
                    {
                        new VisualBasicImportReference
                            {
                                Assembly = typeof(Person).Assembly.GetName().Name,
                                Import = typeof(Person).Namespace
                            }
                    }
            };
            VisualBasic.SetSettings(activity, settings);
        }
    }
}
