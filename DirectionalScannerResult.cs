﻿using System;
using EVE.ISXEVE.Extensions;
using LavishScriptAPI;

namespace EVE.ISXEVE
{
    /// <summary>
    /// Wrapper for the DirectionalScannerresult datatype.
    /// DirectionalScannerresult is not a typo.
    /// </summary>
    public class DirectionalScannerResult : LavishScriptObject
    {
        public DirectionalScannerResult(LavishScriptObject Copy) : base(Copy)
        {
        }

        private Int64? _id;
        /// <summary>
        /// Wrapper for the ID member of the DirectionalScannerresult datatype.
        /// </summary>
        public Int64 ID
        {
            get
            {
                if (_id == null)
                    _id = this.GetInt64("ID");

                return _id.Value;
            }
        }

        private string _name;
        /// <summary>
        /// Wrapper for the Name member of the DirectionalScannerresult datatype.
        /// </summary>
        public string Name
        {
            get { return _name ?? (_name = this.GetString("Name")); }
        }

        private int? _groupId;
        /// <summary>
        /// Wrapper for the GroupID member of the DirectionalScannerresult datatype.
        /// </summary>
        public int GroupID
        {
            get
            {
                if (_groupId == null)
                    _groupId = this.GetInt("GroupID");

                return _groupId.Value;
            }
        }

        private int? _typeId;
        /// <summary>
        /// Wrapper for the TypeID member of the DirectionalScannerresult datatype.
        /// </summary>
        public int TypeID
        {
            get
            {
                if (_typeId == null)
                    _typeId = this.GetInt("TypeID");

                return _typeId.Value;
            }
        }

        private Entity _toEntity;
        /// <summary>
        /// Wrapper for the ToEntity member of the DirectionalScannerresult datatype.
        /// </summary>
        public Entity ToEntity
        {
            get { return _toEntity ?? (_toEntity = new Entity(GetMember("ToEntity"))); }
        }
    }
}
