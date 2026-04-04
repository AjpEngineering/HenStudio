#region HEADER
//#####################################################################################################################
//###############################  P r o f i l e V i e w M o d e l T e s t H e l p e r s . c s  ########################
//#####################################################################################################################
//  FILENAME:  ProfileViewModelTestHelpers.cs
//  NAMESPACE: HenStudio.Tests.Profile
//  CLASS(S):  ProfileViewModelTestHelpers
//  COMPONENT: HenStudio.Tests.dll
//=====================================================================================================================
//  DESCRIPTION:
//    This file contains helper methods for profile view model unit tests.
//=====================================================================================================================
//  AUTHOR:
//!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
//                                                                                                                   !!
//                              A        JJJJJJJJ  PPPPPPP         EEEEEEE  NN     NN   GGGGGG                       !!
//                             AAA          JJ     PP    PP        EE       NNN    NN  GG    GG                      !!
//                            AA AA         JJ     PP    PP        EE       NNNN   NN  GG                            !!
//                           AA   AA        JJ     PPPPPP          EEEEEEE  NN NN  NN  GG   GGGG                     !!
//                          AAAAAAAA   JJ   JJ     PP              EE       NN  NN NN  GG    GG                      !!
//                         AA      AA  JJ   JJ     PP              EE       NN    NNN  GG    GG                      !!
//                        AA        AA  JJJJJJ     PP              EEEEEEE  NN     NN   GGGGGG                       !!
//                                                                                                                   !!
//!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
//    (c)Copyright 2026 AJP Engineering
//    All rights reserved.
//=====================================================================================================================
//  HISTORY:
//    01/01/26 .. AJP Engineering .. Version 1.0
//#####################################################################################################################
//#####################################################################################################################
//#####################################################################################################################
#endregion      // HEADER

#region REFERENCES
using HenGlobal;
using HenStudio.Tests.System;

using static HenGlobal.HenProjectUnits;

using System;
using System.Data;
#endregion      // REFERENCES

#region namespace HenStudio.Tests.Profile
namespace HenStudio.Tests.Profile
{
    #region internal static class ProfileViewModelTestHelpers
    /// <summary>
    /// Helper methods for profile view model unit tests.
    /// </summary>
    internal static class ProfileViewModelTestHelpers
    {
        #region CreateExternalUnits()
        /// <summary>
        /// Creates the external project units object for unit testing.
        /// </summary>
        /// <returns>A <see cref="HenProjectUnits"/> object configured for English base units.</returns>
        internal static HenProjectUnits CreateExternalUnits()
        {
            HenProjectUnits externalUnits = new HenProjectUnits();

            externalUnits.ProjectSystemUnitsEnum = ProjectSystemUnits.ENGLISH;
            externalUnits.ProjectMagnitudeEnum = ProjectMagnitude.BASE;
            externalUnits.ProjectEnglishTempEnum = ProjectEnglishTemp.DEG_F;
            externalUnits.ProjectEnglishPressEnum = ProjectEnglishPress.PSIA;
            externalUnits.ProjectEnglishAreaEnum = ProjectEnglishArea.FT2;

            return externalUnits;
        }
        #endregion      // CreateExternalUnits()

        #region CreateInternalUnits()
        /// <summary>
        /// Creates the internal project units object for unit testing.
        /// </summary>
        /// <returns>A <see cref="HenProjectUnits"/> object configured with default internal units.</returns>
        internal static HenProjectUnits CreateInternalUnits()
        {
            return new HenProjectUnits();
        }
        #endregion      // CreateInternalUnits()

        #region GetParameterValue()
        /// <summary>
        /// Gets a parameter value from the fake command by parameter name.
        /// </summary>
        /// <param name="command">The fake database command.</param>
        /// <param name="parameterName">The parameter name to retrieve.</param>
        /// <returns>The parameter value.</returns>
        internal static object GetParameterValue(TestDbCommand command, string parameterName)
        {
            foreach (IDbDataParameter parameter in command.CapturedParameters)
            {
                if (String.Equals(parameter.ParameterName, parameterName, StringComparison.Ordinal))
                {
                    return parameter.Value;
                }
            }

            return null;
        }
        #endregion      // GetParameterValue()
    }
    #endregion      // internal static class ProfileViewModelTestHelpers
}
#endregion      // namespace HenStudio.Tests.Profile

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
