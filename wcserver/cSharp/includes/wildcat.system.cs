//***********************************************************************
// (c) Copyright 1998-2020 Santronics Software, Inc. All Rights Reserved.
//***********************************************************************
//
// File Name : wildcat.system.cs
// Subsystem : Wildcat! SDK for c#
// Version   : 8.0.454.10
// Author    : SSI
// About     : Namespace for Wildcat! system session.
//
// Revision History:
// Build    Date      Author  Comments
// -----    --------  ------  -------------------------------------------
// 454.10   05/18/20  SSI     - Created
//***********************************************************************

using System;
//using System.Collections.Generic;
//using System.Text;

namespace wcSDK.wcSystem
{
    public class WildcatException : Exception
    {
        public WildcatException(string message) : base(message)
        {
        }
    }

    public class wcGlobal
    {

        #region properties

        public static wcServerAPI.TMakewild Makewild = new wcServerAPI.TMakewild();
        public static wcServerAPI.TUser User = new wcServerAPI.TUser();
        public static int Node { get { return wcServerAPI.GetNode(); } }
        public static bool AnsiDetected { get; set; }
        #endregion

        public wcGlobal()
        {
            if (!wcServerAPI.GetMakewild(ref Makewild)) {
                throw new WildcatException("GetMakewild() error");
            }
        }

    }
}

