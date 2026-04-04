#region HEADER
//#####################################################################################################################
//#####################################  G l o b a l S e t t i n g s R e p o T e s t s . c s  #########################
//#####################################################################################################################
//  FILENAME:  GlobalSettingsRepoTests.cs
//  NAMESPACE: HenStudio.Tests.System
//  CLASS(S):  GlobalSettingsRepoTests
//  COMPONENT: HenStudio.Tests.dll
//=====================================================================================================================
//  DESCRIPTION:
//    This file contains NUnit unit tests for the GlobalSettingsRepo class.
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
using HenPersistence.Repos;
using HenRepositories.Dto;

using System;
using System.Collections.Generic;
using System.Data;

using NUnit.Framework;
#endregion      // REFERENCES

#region namespace HenStudio.Tests.System
namespace HenStudio.Tests.System
{
    #region public class GlobalSettingsRepoTests
    /// <summary>
    /// Unit tests for the <see cref="GlobalSettingsRepo"/> class.
    /// </summary>
    [TestFixture]
    public class GlobalSettingsRepoTests
    {
        #region PRIVATE METHODS

        #region CreateReader()
        /// <summary>
        /// Creates a global settings data reader for unit testing.
        /// </summary>
        /// <param name="settings">The settings to expose through the reader.</param>
        /// <returns>An <see cref="IDataReader"/> over the supplied setting rows.</returns>
        private static IDataReader CreateReader(params GlobalSettingsDto[] settings)
        {
            DataTable table = new DataTable();

            table.Columns.Add("SettingKey", typeof(string));
            table.Columns.Add("SettingValue", typeof(string));
            table.Columns.Add("ValueType", typeof(string));
            table.Columns.Add("Description", typeof(string));
            table.Columns.Add("UpdatedOn", typeof(DateTime));

            foreach (GlobalSettingsDto setting in settings)
            {
                table.Rows.Add(
                    (object)setting.SettingKey ?? DBNull.Value,
                    (object)setting.SettingValue ?? DBNull.Value,
                    (object)setting.ValueType ?? DBNull.Value,
                    (object)setting.Description ?? DBNull.Value,
                    setting.UpdatedOn);
            }

            return table.CreateDataReader();
        }
        #endregion      // CreateReader()

        #region GetParameterValue()
        /// <summary>
        /// Gets a parameter value from the fake command by parameter name.
        /// </summary>
        /// <param name="command">The fake database command.</param>
        /// <param name="parameterName">The parameter name to retrieve.</param>
        /// <returns>The parameter value.</returns>
        private static object GetParameterValue(TestDbCommand command, string parameterName)
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

        #endregion      // PRIVATE METHODS

        #region GlobalSettingsRepo_CTOR_WithNullConnectionFactory_ThrowsArgumentNullException()
        /// <summary>
        /// Verifies that the constructor throws when the connection factory is null.
        /// </summary>
        [Test]
        public void GlobalSettingsRepo_CTOR_WithNullConnectionFactory_ThrowsArgumentNullException()
        {
            Assert.That(() => new GlobalSettingsRepo(null), Throws.ArgumentNullException);
        }
        #endregion      // GlobalSettingsRepo_CTOR_WithNullConnectionFactory_ThrowsArgumentNullException()

        #region GetGlobalSettings_ReturnsMappedSettings()
        /// <summary>
        /// Verifies that GetGlobalSettings returns the mapped settings.
        /// </summary>
        [Test]
        public void GetGlobalSettings_ReturnsMappedSettings()
        {
            TestDbCommand command = new TestDbCommand();
            TestDbConnection connection = new TestDbConnection(command);
            GlobalSettingsRepo repo = new GlobalSettingsRepo(new TestDbConnectionFactory(connection));
            GlobalSettingsDto setting1 = new GlobalSettingsDto
            {
                SettingKey = "DefaultLanguage",
                SettingValue = "en-US",
                ValueType = "String",
                Description = "Default language setting",
                UpdatedOn = new DateTime(2026, 1, 1)
            };
            GlobalSettingsDto setting2 = new GlobalSettingsDto
            {
                SettingKey = "OptionalSetting",
                SettingValue = null,
                ValueType = null,
                Description = null,
                UpdatedOn = new DateTime(2026, 1, 2)
            };

            command.ReaderResult = CreateReader(setting1, setting2);

            IList<GlobalSettingsDto> result = repo.GetGlobalSettings();

            Assert.That(connection.OpenWasCalled, Is.True);
            Assert.That(command.ExecuteReaderWasCalled, Is.True);
            Assert.That(command.CommandType, Is.EqualTo(CommandType.Text));
            Assert.That(command.CommandText, Does.Contain("FROM dbo.GlobalSettings"));
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count, Is.EqualTo(2));
            Assert.That(result[0].SettingKey, Is.EqualTo("DefaultLanguage"));
            Assert.That(result[0].SettingValue, Is.EqualTo("en-US"));
            Assert.That(result[0].ValueType, Is.EqualTo("String"));
            Assert.That(result[0].Description, Is.EqualTo("Default language setting"));
            Assert.That(result[0].UpdatedOn, Is.EqualTo(new DateTime(2026, 1, 1)));
            Assert.That(result[1].SettingKey, Is.EqualTo("OptionalSetting"));
            Assert.That(result[1].SettingValue, Is.Null);
            Assert.That(result[1].ValueType, Is.Null);
            Assert.That(result[1].Description, Is.Null);
            Assert.That(result[1].UpdatedOn, Is.EqualTo(new DateTime(2026, 1, 2)));
        }
        #endregion      // GetGlobalSettings_ReturnsMappedSettings()

        #region GetGlobalSettings_ReturnsEmptyList_WhenNoRowsExist()
        /// <summary>
        /// Verifies that GetGlobalSettings returns an empty list when no rows exist.
        /// </summary>
        [Test]
        public void GetGlobalSettings_ReturnsEmptyList_WhenNoRowsExist()
        {
            TestDbCommand command = new TestDbCommand();
            TestDbConnection connection = new TestDbConnection(command);
            GlobalSettingsRepo repo = new GlobalSettingsRepo(new TestDbConnectionFactory(connection));

            command.ReaderResult = CreateReader();

            IList<GlobalSettingsDto> result = repo.GetGlobalSettings();

            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count, Is.EqualTo(0));
        }
        #endregion      // GetGlobalSettings_ReturnsEmptyList_WhenNoRowsExist()

        #region GetGlobalSettingsByKey_ThrowsArgumentException_WhenSettingKeyIsBlank()
        /// <summary>
        /// Verifies that GetGlobalSettingsByKey throws when the setting key is blank.
        /// </summary>
        [Test]
        public void GetGlobalSettingsByKey_ThrowsArgumentException_WhenSettingKeyIsBlank()
        {
            TestDbCommand command = new TestDbCommand();
            TestDbConnection connection = new TestDbConnection(command);
            GlobalSettingsRepo repo = new GlobalSettingsRepo(new TestDbConnectionFactory(connection));

            Assert.That(() => repo.GetGlobalSettingsByKey(" "), Throws.ArgumentException);
        }
        #endregion      // GetGlobalSettingsByKey_ThrowsArgumentException_WhenSettingKeyIsBlank()

        #region GetGlobalSettingsByKey_ReturnsMappedSetting_WhenFound()
        /// <summary>
        /// Verifies that GetGlobalSettingsByKey returns the mapped setting when a row is found.
        /// </summary>
        [Test]
        public void GetGlobalSettingsByKey_ReturnsMappedSetting_WhenFound()
        {
            TestDbCommand command = new TestDbCommand();
            TestDbConnection connection = new TestDbConnection(command);
            GlobalSettingsRepo repo = new GlobalSettingsRepo(new TestDbConnectionFactory(connection));
            GlobalSettingsDto setting = new GlobalSettingsDto
            {
                SettingKey = "DefaultLanguage",
                SettingValue = "en-US",
                ValueType = "String",
                Description = "Default language setting",
                UpdatedOn = new DateTime(2026, 1, 1)
            };

            command.ReaderResult = CreateReader(setting);

            GlobalSettingsDto result = repo.GetGlobalSettingsByKey("DefaultLanguage");

            Assert.That(connection.OpenWasCalled, Is.True);
            Assert.That(command.ExecuteReaderWasCalled, Is.True);
            Assert.That(command.CommandText, Does.Contain("WHERE SettingKey = @SettingKey"));
            Assert.That(GetParameterValue(command, "@SettingKey"), Is.EqualTo("DefaultLanguage"));
            Assert.That(result, Is.Not.Null);
            Assert.That(result.SettingKey, Is.EqualTo(setting.SettingKey));
            Assert.That(result.SettingValue, Is.EqualTo(setting.SettingValue));
            Assert.That(result.ValueType, Is.EqualTo(setting.ValueType));
            Assert.That(result.Description, Is.EqualTo(setting.Description));
            Assert.That(result.UpdatedOn, Is.EqualTo(setting.UpdatedOn));
        }
        #endregion      // GetGlobalSettingsByKey_ReturnsMappedSetting_WhenFound()

        #region GetGlobalSettingsByKey_ReturnsNull_WhenNotFound()
        /// <summary>
        /// Verifies that GetGlobalSettingsByKey returns null when no row is found.
        /// </summary>
        [Test]
        public void GetGlobalSettingsByKey_ReturnsNull_WhenNotFound()
        {
            TestDbCommand command = new TestDbCommand();
            TestDbConnection connection = new TestDbConnection(command);
            GlobalSettingsRepo repo = new GlobalSettingsRepo(new TestDbConnectionFactory(connection));

            command.ReaderResult = CreateReader();

            GlobalSettingsDto result = repo.GetGlobalSettingsByKey("MissingSetting");

            Assert.That(result, Is.Null);
        }
        #endregion      // GetGlobalSettingsByKey_ReturnsNull_WhenNotFound()
    }
    #endregion      // public class GlobalSettingsRepoTests
}
#endregion      // namespace HenStudio.Tests.System

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
