#region HEADER
//#####################################################################################################################
//####################################  C o n n e c t i o n I n f o R e p o T e s t s . c s  ##########################
//#####################################################################################################################
//  FILENAME:  ConnectionInfoRepoTests.cs
//  NAMESPACE: HenStudio.Tests.Connection
//  CLASS(S):  ConnectionInfoRepoTests
//  COMPONENT: HenStudio.Tests.dll
//=====================================================================================================================
//  DESCRIPTION:
//    This file contains NUnit unit tests for the connection info repository implementation.
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

using NUnit.Framework;
#endregion      // REFERENCES

#region namespace HenStudio.Tests.Connection
namespace HenStudio.Tests.Connection
{
    #region public class ConnectionInfoRepoTests
    /// <summary>
    /// Unit tests for the connection info repository implementation.
    /// </summary>
    [TestFixture]
    public class ConnectionInfoRepoTests
    {
        #region ConnectionInfoRepo_CTOR_WithNullConnectionFactory_ThrowsArgumentNullException()
        /// <summary>
        /// Verifies that the constructor throws when the connection factory is null.
        /// </summary>
        [Test]
        public void ConnectionInfoRepo_CTOR_WithNullConnectionFactory_ThrowsArgumentNullException()
        {
            Assert.That(() => new ConnectionDataRepo(null), Throws.ArgumentNullException);
        }
        #endregion      // ConnectionInfoRepo_CTOR_WithNullConnectionFactory_ThrowsArgumentNullException()

        #region ConnectionInfoRepo_GetConnectionData_WithFakeSqlConnection_ReturnsExpectedValues()
        /// <summary>
        /// Verifies that GetConnectionData returns the expected connection metadata values.
        /// </summary>
        [Test]
        public void ConnectionInfoRepo_GetConnectionData_WithFakeSqlConnection_ReturnsExpectedValues()
        {
            FakeSqlConnection connection = new FakeSqlConnection(
                "localhost\\HENSTUDIO",
                "HenStudio",
                "ajpuser",
                "password",
                "AJPWORKSTATION",
                45,
                8192,
                "16.0.1000.6");
            ConnectionDataRepo repo = new ConnectionDataRepo(new FakeConnectionFactory(connection));

            ConnectionDataDto result = repo.GetConnectionData();

            Assert.That(result.DataSource, Is.EqualTo("localhost\\HENSTUDIO"));
            Assert.That(result.UserId, Is.EqualTo("ajpuser"));
            Assert.That(result.WorkstationId, Is.EqualTo("AJPWORKSTATION"));
            Assert.That(result.InitialCatalog, Is.EqualTo("HenStudio"));
            Assert.That(result.Timeout, Is.EqualTo(45));
            Assert.That(result.PacketSize, Is.EqualTo(8192));
            Assert.That(result.ServerVersion, Is.EqualTo("16.0.1000.6"));
            Assert.That(result.ConnectionState, Is.EqualTo("Open"));
        }
        #endregion      // ConnectionInfoRepo_GetConnectionData_WithFakeSqlConnection_ReturnsExpectedValues()

        #region ConnectionInfoRepo_GetConnectionData_WithIntegratedSecurity_ReturnsIntegratedSecurityUserId()
        /// <summary>
        /// Verifies that GetConnectionData returns Integrated Security when the connection uses integrated security.
        /// </summary>
        [Test]
        public void ConnectionInfoRepo_GetConnectionData_WithIntegratedSecurity_ReturnsIntegratedSecurityUserId()
        {
            FakeSqlConnection connection = new FakeSqlConnection(
                "localhost\\HENSTUDIO",
                "HenStudio",
                String.Empty,
                String.Empty,
                "AJPWORKSTATION",
                30,
                8000,
                "16.0.1000.6",
                true);
            ConnectionDataRepo repo = new ConnectionDataRepo(new FakeConnectionFactory(connection));

            ConnectionDataDto result = repo.GetConnectionData();

            Assert.That(result.UserId, Is.EqualTo("Integrated Security"));
        }
        #endregion      // ConnectionInfoRepo_GetConnectionData_WithIntegratedSecurity_ReturnsIntegratedSecurityUserId()
    }
    #endregion      // public class ConnectionInfoRepoTests
}
#endregion      // namespace HenStudio.Tests.Connection

//=====================================================================================================================
//---------------------------------------------  E N D   O F   F I L E  -----------------------------------------------
//=====================================================================================================================
